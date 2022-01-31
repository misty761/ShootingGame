using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class RetryGold : MonoBehaviour
{
    bool isPressed;
    public Text textRetryPrice;
    int cost = 20;

    // Start is called before the first frame update
    void Start()
    {
        EventTrigger eventTrigger = gameObject.AddComponent<EventTrigger>();
        EventTrigger.Entry entry_TouchUp = new EventTrigger.Entry();
        entry_TouchUp.eventID = EventTriggerType.PointerUp;
        entry_TouchUp.callback.AddListener((data) => { TouchUp(); });
        eventTrigger.triggers.Add(entry_TouchUp);

        isPressed = false;

        LanguageManager.instance.SetTextRetryPayGold(textRetryPrice, cost);
    }

    private void TouchUp()
    {
        SoundControl.instance.PlaySound(SoundControl.instance.audioClipClick);
        isPressed = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isPressed)
        {
            isPressed = false;

            int gold = PlayerPrefs.GetInt("Gold", 0);
            
            if (gold >= cost)
            {
                SoundControl.instance.PlaySound(SoundControl.instance.audioClipClick);
                gold -= cost;
                GoldManager.instance.gold = gold;
                PlayerPrefs.SetInt("Gold", gold);
                GameManager.instance.RetryGame();
            }
            else
            {
                SoundControl.instance.PlaySound(SoundControl.instance.audioDenied);
            }
        }
    }
}

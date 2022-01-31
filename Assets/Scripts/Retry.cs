using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Retry : MonoBehaviour
{
    GoogleMobileAdsReward googleAD;
    bool isPressed;
    
    // Start is called before the first frame update
    void Start()
    {
        EventTrigger eventTrigger = gameObject.AddComponent<EventTrigger>();
        EventTrigger.Entry entry_TouchUp = new EventTrigger.Entry();
        entry_TouchUp.eventID = EventTriggerType.PointerUp;
        entry_TouchUp.callback.AddListener((data) => { TouchUp(); });
        eventTrigger.triggers.Add(entry_TouchUp);

        googleAD = FindObjectOfType<GoogleMobileAdsReward>();

        isPressed = false;
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
            if (googleAD.rewardedAd.IsLoaded())
            {
                isPressed = false;
                googleAD.rewardedAd.Show();
            }
        }

        if (googleAD.isRewarded && googleAD.bCloseAD)
        {
            GameManager.instance.RetryGame();
        }
    }
}

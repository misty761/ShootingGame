using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    float speed = 5f;
    string stringGold;

    private void Start()
    {
        stringGold = LanguageManager.instance.SetText("Gold");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = Vector3.down;
        transform.position += dir * speed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name.Contains("Player"))
        {
            SoundControl.instance.PlaySound(SoundControl.instance.audioCoin);

            int price = 1;

            GoldManager.instance.gold += price;

            int gold = GoldManager.instance.gold;

            PlayerPrefs.SetInt("Gold", gold);

            // 플로팅 메세지 표시
            ItemManager.instance.SetFloatingText(stringGold + " +" + price, transform.position);
        }

        Destroy(gameObject);
    }
}

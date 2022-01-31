using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyPlane : MonoBehaviour
{
    public GameObject buttonStart;
    public Text textPrice;
    SelectPlaneButton buttonSelectPlane;
    int price = 20;


    private void Start()
    {
        buttonSelectPlane = FindObjectOfType<SelectPlaneButton>();

        LanguageManager.instance.SetTextBuyPlane(textPrice, price);
        
    }

    public void Buy()
    {
        int gold = PlayerPrefs.GetInt("Gold", 0);
        
        if (gold >= price)
        {
            SoundControl.instance.PlaySound(SoundControl.instance.audioCoin);
            gold -= price;
            GoldManager.instance.gold = gold;
            PlayerPrefs.SetInt("Gold", gold);
            int planeNo = buttonSelectPlane.selectedPlane;   // 0~11
            PlayerPrefs.SetInt("BuyPlane" + planeNo, 1);
            PlayerPrefs.SetInt("Plane", planeNo);
            buttonStart.SetActive(true);
            gameObject.SetActive(false);
        }
        else
        {
            SoundControl.instance.PlaySound(SoundControl.instance.audioDenied);
        }
    }
}

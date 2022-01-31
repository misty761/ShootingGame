using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldDisplay : MonoBehaviour
{
    public Text textGold;

    // Update is called once per frame
    void Update()
    {
        int gold = PlayerPrefs.GetInt("Gold", 0);
        textGold.text = "" + gold;
    }
}

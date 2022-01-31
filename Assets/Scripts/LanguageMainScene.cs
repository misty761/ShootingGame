using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LanguageMainScene : MonoBehaviour
{
    public Text textNewRecord;
    public Text textGameOver;
    public Text textRetry;
    public Text textYes;
    public Text textNo;
    public Text textSeeAD;
    public Text textGoToTitle;

    // Start is called before the first frame update
    void Start()
    {
        LanguageManager.instance.SetTextNewRecord(textNewRecord);
        LanguageManager.instance.SetTextGameOver(textGameOver);
        LanguageManager.instance.SetTextRetry(textRetry);
        LanguageManager.instance.SetTextYes(textYes);
        LanguageManager.instance.SetTextNo(textNo);
        LanguageManager.instance.SetTextSeeAD(textSeeAD);
        LanguageManager.instance.SetTextGoTitle(textGoToTitle);
    }
}

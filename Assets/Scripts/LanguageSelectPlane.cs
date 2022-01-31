using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LanguageSelectPlane : MonoBehaviour
{
    public Text textStartGame;

    // Start is called before the first frame update
    void Start()
    {
        LanguageManager.instance.SetTextStartGame(textStartGame);
    }

}

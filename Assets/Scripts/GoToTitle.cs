using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToTitle : MonoBehaviour
{
    public GameObject uiGoToTitle;

    public void YesButton()
    {
        SceneManager.LoadScene("TitleScene");
    }

    public void NoButton()
    {
        Time.timeScale = 1;
        uiGoToTitle.SetActive(false);
    }
}

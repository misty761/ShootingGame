using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void StartGameButton()
    {
        SoundControl.instance.PlaySound(SoundControl.instance.audioClipClick);
        SceneManager.LoadScene("MainScene");
    }
}

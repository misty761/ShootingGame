using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectPlane : MonoBehaviour
{
    public void SelectPlaneButton()
    {
        SoundControl.instance.PlaySound(SoundControl.instance.audioClipClick);
        SceneManager.LoadScene("SelectPlaneScene");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectLanguageButton : MonoBehaviour
{
    public GameObject selectLanguageMenu;

    public void ButtonPress()
    {
        SoundControl.instance.PlaySound(SoundControl.instance.audioClipClick);
        selectLanguageMenu.SetActive(true);
        print("select language button");
    }

    public void SelectEnglish()
    {
        SoundControl.instance.PlaySound(SoundControl.instance.audioClipClick);
        PlayerPrefs.SetString("Language", "English");
        selectLanguageMenu.SetActive(false);
        LanguageManager.instance.SelectLanguage();
    }

    public void SelectKorean()
    {
        SoundControl.instance.PlaySound(SoundControl.instance.audioClipClick);
        PlayerPrefs.SetString("Language", "Korean");
        selectLanguageMenu.SetActive(false);
        LanguageManager.instance.SelectLanguage();
    }

    public void SelectChinese()
    {
        SoundControl.instance.PlaySound(SoundControl.instance.audioClipClick);
        PlayerPrefs.SetString("Language", "Chinese");
        selectLanguageMenu.SetActive(false);
        LanguageManager.instance.SelectLanguage();
    }

    public void SelectFrench()
    {
        SoundControl.instance.PlaySound(SoundControl.instance.audioClipClick);
        PlayerPrefs.SetString("Language", "French");
        selectLanguageMenu.SetActive(false);
        LanguageManager.instance.SelectLanguage();
    }

    public void SelectGerman()
    {
        SoundControl.instance.PlaySound(SoundControl.instance.audioClipClick);
        PlayerPrefs.SetString("Language", "German");
        selectLanguageMenu.SetActive(false);
        LanguageManager.instance.SelectLanguage();
    }

    public void SelectJapanese()
    {
        SoundControl.instance.PlaySound(SoundControl.instance.audioClipClick);
        PlayerPrefs.SetString("Language", "Japanese");
        selectLanguageMenu.SetActive(false);
        LanguageManager.instance.SelectLanguage();
    }

    public void SelectPortugal()
    {
        SoundControl.instance.PlaySound(SoundControl.instance.audioClipClick);
        PlayerPrefs.SetString("Language", "Portugal");
        selectLanguageMenu.SetActive(false);
        LanguageManager.instance.SelectLanguage();
    }

    public void SelectRussian()
    {
        SoundControl.instance.PlaySound(SoundControl.instance.audioClipClick);
        PlayerPrefs.SetString("Language", "Russian");
        selectLanguageMenu.SetActive(false);
        LanguageManager.instance.SelectLanguage();
    }

    public void SelectSpanish()
    {
        SoundControl.instance.PlaySound(SoundControl.instance.audioClipClick);
        PlayerPrefs.SetString("Language", "Spanish");
        selectLanguageMenu.SetActive(false);
        LanguageManager.instance.SelectLanguage();
    }

    public void SelectItalian()
    {
        SoundControl.instance.PlaySound(SoundControl.instance.audioClipClick);
        PlayerPrefs.SetString("Language", "Italian");
        selectLanguageMenu.SetActive(false);
        LanguageManager.instance.SelectLanguage();
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SoundControl : MonoBehaviour
{
    // Start is called before the first frame update
    public static SoundControl instance;
    public GameObject imageSoundOn;
    public GameObject imageSoundOff;
    public AudioClip audioClipGameOver;
    public AudioClip audioClipClick;
    public AudioClip audioClipFanfare;
    public AudioClip audioScore;
    public AudioClip audioLifeUp;
    public AudioClip audioWatch;
    public AudioClip audioFreeze;
    public AudioClip audioPowerUp;
    public AudioClip audioFireUp;
    public AudioClip audioDestroyAllEnemy;
    public AudioClip audioExplosion;
    public AudioClip audioDenied;
    public AudioClip audioCoin;

    public bool isSoundOn;

    private AudioSource audioSource;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Debug.LogWarning("SoundControl is already existed!");
            Destroy(gameObject);
        }
    }

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        int soundState = PlayerPrefs.GetInt("SoundState", 1);
        if (soundState != 0) 
        {
            isSoundOn = true;
        } 
        else 
        {
            isSoundOn = false;
        }
        SetSound();

        EventTrigger eventTrigger = gameObject.AddComponent<EventTrigger>();
        EventTrigger.Entry entry_TouchUp = new EventTrigger.Entry();
        entry_TouchUp.eventID = EventTriggerType.PointerUp;
        entry_TouchUp.callback.AddListener((data) => { TouchUp(); });
        eventTrigger.triggers.Add(entry_TouchUp);
    }

    private void SetSound()
    {
        if (isSoundOn)
        {
            imageSoundOn.SetActive(true);
            imageSoundOff.SetActive(false);
            PlayerPrefs.SetInt("SoundState", 1);    // 0: music off, 1: music on
        }
        else{
            imageSoundOn.SetActive(false);
            imageSoundOff.SetActive(true);
            PlayerPrefs.SetInt("SoundState", 0);    // 0: music off, 1: music on
        }
    }

    private void TouchUp()
    {
        isSoundOn = !isSoundOn;
        PlaySound(audioClipClick);
        SetSound();
    }

    public void PlaySound(AudioClip audioClip)
    {
        if (isSoundOn) audioSource.PlayOneShot(audioClip);
    }

    public void PlaySound(AudioSource audio, AudioClip audioClip)
    {
        if (isSoundOn) audio.PlayOneShot(audioClip);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuSFXSounds : MonoBehaviour
{
    public AudioClip[] soundPressButton;
    public AudioClip[] soundCancelButton;

    private AudioSource myAudioSource;

    void Awake()
    {
        myAudioSource = GetComponent<AudioSource>();
    }

    public void PressButton()
    {
        AudioClip clip = soundPressButton[UnityEngine.Random.Range(0, soundPressButton.Length)];
        myAudioSource.PlayOneShot(clip);
    }

    public void PressCancelButton()
    {
        AudioClip clip = soundCancelButton[UnityEngine.Random.Range(0, soundCancelButton.Length)];
        myAudioSource.PlayOneShot(clip);
    }
}

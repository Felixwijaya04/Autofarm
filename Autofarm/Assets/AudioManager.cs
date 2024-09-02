using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("Audio Source")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource sfxSource;

    [Header("Audio Clip")]
    public AudioClip bgm;
    public AudioClip[] sfx;
    public AudioClip[] coreGameSfx;

    public void playBGM()
    {
        musicSource.clip = bgm;
        musicSource.Play();
    }

    public void playSFX(AudioClip clip)
    {
        sfxSource.PlayOneShot(clip);
    }
}

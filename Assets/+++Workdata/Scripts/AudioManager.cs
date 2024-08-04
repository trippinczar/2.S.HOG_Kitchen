using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using System;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance; // Easy accessible from anywhere
    
    public Sound[] musicSounds, sfxSounds;
    public AudioSource musicSource, sfxSource;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Keeps the music playing when scene is changed
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        PlayMusic("ThemeMusic"); // Plays when game starts
    }

    // Function for Music
    public void PlayMusic(string name)
    {
        Sound s = Array.Find(musicSounds, x => x.name == name); // Finds the audio, needs using.System;

        if (s == null) // if no music with the name s
        {
            Debug.Log("Sound not found");
        }
        else // if music with the name s
        {
            musicSource.clip = s.clip;
            musicSource.Play(); // Plays the clip
        }
    }

    // Function for SFX sound
    public void PlaySFX(string name)
    {
        Sound s = Array.Find(sfxSounds, x => x.name == name); // Finds the audio, needs using.System;

        if (s == null) // if no music with the name s
        {
            Debug.Log("Sound not found");
        }
        else
        {
            sfxSource.PlayOneShot(s.clip); // Plays an AudioClip, and scales the AudioSource volume by volumeScale
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioScript : MonoBehaviour
{
    // audio source
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    // audio clip
    public AudioClip backgroundMusic;
    public AudioClip cageHit;
    public AudioClip cageBreak;
    public AudioClip winNoise;
    public AudioClip menuSelectNoise;
    public AudioClip restartLevel;

    [SerializeField] private bool startedMusic = false;

    public audioScript Instance { get; private set; }

    private void Awake()
    {
        // Keep this object alive across scenes
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject); // Prevent duplicates
        }
    }

    private void Start()
    {
        if (startedMusic == false)
        {
            musicSource.clip = backgroundMusic;
            musicSource.Play();
            startedMusic = true;
        }
    }

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }
}

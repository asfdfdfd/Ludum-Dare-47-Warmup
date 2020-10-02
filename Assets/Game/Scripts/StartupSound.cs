using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class StartupSound : MonoBehaviour
{
    [SerializeField] private AudioClip[] sounds;

    private AudioSource _audioSource;
    
    private Random random = new Random();
    
    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();

        _audioSource.clip = sounds[random.Next(0, sounds.Length)];
        _audioSource.Play();
    }
}

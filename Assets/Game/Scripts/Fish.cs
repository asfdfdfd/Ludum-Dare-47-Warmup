using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fish : MonoBehaviour
{
    private GameObject gameObjectBubble;
    private Collider2D colliderBubble;
    private PlayerController _playerController;
    
    [SerializeField] private AudioSource soundPlayerHit;
    
    private void Start()
    {
        gameObjectBubble = GameObject.Find("Player");
        colliderBubble = gameObjectBubble.GetComponent<Collider2D>();
        _playerController = gameObjectBubble.GetComponent<PlayerController>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other == colliderBubble)
        {
            _playerController.Kill(soundPlayerHit);
        }
    }
}

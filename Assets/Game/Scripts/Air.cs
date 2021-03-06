﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Air : MonoBehaviour
{
    private GameObject gameObjectBubble;
    private Collider2D colliderBubble;
    private PlayerController playerController;

    public float AmountOfAir;
    
    private void Start()
    {
        gameObjectBubble = GameObject.Find("Player");
        colliderBubble = gameObjectBubble.GetComponent<Collider2D>();
        playerController = gameObjectBubble.GetComponent<PlayerController>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other == colliderBubble)
        {
            playerController.AddAir(AmountOfAir);
            
            Destroy(gameObject);
        }
    }
}

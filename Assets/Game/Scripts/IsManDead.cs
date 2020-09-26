using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IsManDead : MonoBehaviour
{
    private GameObject gameObjectMan;

    private Collider2D colliderMan;
    
    private void Start()
    {
        gameObjectMan = GameObject.Find("Man");
        colliderMan = gameObjectMan.GetComponent<Collider2D>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other == colliderMan)
        {
            SceneManager.LoadScene("GameOverScene");
        }
    }
}

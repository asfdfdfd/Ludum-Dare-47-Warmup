using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerWins : MonoBehaviour
{
    private GameObject gameObjectBubble;
    private Collider2D colliderBubble;
    private void Start()
    {
        gameObjectBubble = GameObject.Find("Player");
        colliderBubble = gameObjectBubble.GetComponent<Collider2D>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other == colliderBubble)
        {
            SceneManager.LoadScene("WinScene");
        }
    }
}

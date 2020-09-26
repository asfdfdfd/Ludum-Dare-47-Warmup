using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class FishTrigger : MonoBehaviour
{
    public GameObject FishEndPosition;

    public GameObject FishGameObject;

    public float Duration;

    private GameObject gameObjectBubble;
    private Collider2D colliderBubble;
    private void Start()
    {
        GetComponent<SpriteRenderer>().enabled = false;
        
        gameObjectBubble = GameObject.Find("Player");
        colliderBubble = gameObjectBubble.GetComponent<Collider2D>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other == colliderBubble)
        {
            FishGameObject.transform.DOMove(FishEndPosition.transform.position, Duration).OnComplete(() =>
            {
                Destroy(FishGameObject);
            });
        }
    }
}

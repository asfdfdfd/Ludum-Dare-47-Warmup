using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowsBubble : MonoBehaviour
{
    public GameObject gameObjectBubble;

    private float deltaY;

    private void Start()
    {
        deltaY = gameObject.transform.position.y - gameObjectBubble.transform.position.y;
    }

    private void FixedUpdate()
    {
        gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObjectBubble.transform.position.y + deltaY, -10);
    }
}

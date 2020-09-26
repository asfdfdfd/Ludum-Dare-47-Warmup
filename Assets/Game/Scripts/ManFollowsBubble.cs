using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManFollowsBubble : MonoBehaviour
{
    public GameObject gameObjectBubble;

    private void FixedUpdate()
    {
        gameObject.transform.position = gameObjectBubble.transform.position;
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tracker : MonoBehaviour
{
    public Vector2 offset;
    private Vector2 velocity;
    public float smoothTimeX;
    public GameObject active;
    float posX;

    void Update()
    {
        posX = Mathf.SmoothDamp((transform.position.x - offset.x), active.transform.position.x, ref velocity.x, smoothTimeX);
    }
    void LateUpdate()
    {
        transform.position = new Vector3(posX, transform.position.y, transform.position.z);
    }
}

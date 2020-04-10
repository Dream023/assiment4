﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    [SerializeField] float speed;

    void Update()
    {
        transform.Translate(0f,speed*Time.deltaTime,0f);  
    }
}

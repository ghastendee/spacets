﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {

    public float speed;

    void Start()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(0.0f, 0.0f, speed);
    }
}

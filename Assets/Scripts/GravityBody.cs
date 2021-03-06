﻿using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class GravityBody : MonoBehaviour
{

    GravityAttractor planet;

    void Awake()
    {
        planet = GameObject.FindGameObjectWithTag("Planet").GetComponent<GravityAttractor>();

        // Disable rigidbody gravity and rotation as this is simulated in GravityAttractor script
        GetComponent<Rigidbody>().useGravity = false;
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
    }

    void FixedUpdate()
    {
        // Allow this body to be influenced by planet's gravity
        planet.Attract(transform);
    }
}
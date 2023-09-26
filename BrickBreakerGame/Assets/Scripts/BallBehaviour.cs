using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Random = System.Random;


public class BallBehaviour : MonoBehaviour
{
    
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        

    }

    private void Start()
    {
        Vector3 force = Vector3.zero;
        force.x = 1f;
    }
}

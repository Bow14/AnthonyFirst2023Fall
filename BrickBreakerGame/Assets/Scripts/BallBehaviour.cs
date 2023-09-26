using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Random = System.Random;


public class BallBehaviour : MonoBehaviour
{
    // Helped made this scripted with this https://www.youtube.com/watch?v=RYG8UExRkhA Specifically and only with the ball movement chapter
    private Rigidbody rb;
    public float speed = 500f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        

    }

    private void Start()
    {
        
        Invoke(nameof(SetRandomTrajectory), 1f);
        
    }

    private void SetRandomTrajectory()
    {
        Vector3 force = Vector3.zero;
        force.x = UnityEngine.Random.Range(-1f, 1f); // Fixed it with UnityEngine
        force.y = -1f;
        
        this.rb.AddForce(force.normalized * this.speed);
    }
}

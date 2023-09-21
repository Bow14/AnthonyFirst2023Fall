using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickObject : MonoBehaviour
{
    //Code was written using ChatGPT
    //Just experimenting with what works before i officially do anything


    
        public float flickForce = 10.0f; // The force applied when flicking
        private Rigidbody rb;
        private Vector3 flickDirection = Vector3.up;

        private void Start()
        {
            // Get the Rigidbody component attached to this GameObject
            rb = GetComponent<Rigidbody>();
        }

        private void Update()
        {
            // Check for mouse click or touch input
            if (Input.GetMouseButtonDown(0))
            {
                // Get the screen position of the input
                Vector3 mousePosition = Input.mousePosition;
                // Set a depth for the screen position (distance from camera)
                mousePosition.z = 10.0f;
                // Convert the screen position to a world position
                flickDirection = Camera.main.ScreenToWorldPoint(mousePosition) - transform.position;
                // Normalize the direction vector to ensure consistent force
                flickDirection.Normalize();
                // Apply the flick force to the Rigidbody
                rb.AddForce(flickDirection * flickForce, ForceMode.Impulse);
            }
        }
    }



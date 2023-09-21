using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyingForce : MonoBehaviour
{
    
    //Code was written using ChatGPT
    //As well the fucked around with me for a bit
    //Just experimenting with what works before i officially do anything

    public class ApplyForce : MonoBehaviour
{
    public float forceMagnitude = 10.0f; // The magnitude of the force to apply
    public Vector3 forceDirection = Vector3.up; // The direction in which to apply the force

    private Rigidbody rb;

    private void Start()
    {
        // Get the Rigidbody component attached to this GameObject
        rb = GetComponent<Rigidbody>();
    }

    

    private void Update()
    {
        Debug.Log("Updating");
         if (Input.GetKeyDown(KeyCode.Space))
         {
             // Apply the force when the Space key is pressed
             ApplyForceToRigidbody();
             Debug.Log("W was pushed");
         }
        // if (Input.GetKey(KeyCode.UpArrow))
        // {
        //     rb.AddForce(forceDirection, ForceMode.Force);
        //     
        // }
    }

     private void ApplyForceToRigidbody()
     {
         // Calculate the force vector by multiplying the direction by the magnitude
         Vector3 force = forceDirection.normalized * forceMagnitude;
    
         // Apply the force to the Rigidbody
         rb.AddForce(force, ForceMode.Force);
     }
}

}

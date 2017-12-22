using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairMovement : MonoBehaviour
{

    private Rigidbody rb;    

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnTriggerStay(Collider other)
    {
        if (other.transform.tag == "StairUp")
        {
            if (Vector3.Angle(rb.velocity, other.transform.forward) < 90)
            {
                if (rb.velocity.y > 0)
                {
                    float ypos = rb.velocity.y;
                    ypos = 0;
                }
            }
        }
        
        if (other.transform.tag == "stairDown")
        {
        }
        else
        {
            Physics.gravity = new Vector3(0, -10f * 10f, 0);

            Debug.Log("touching stairs");
            if (Input.GetKeyDown(KeyCode.S))
            {
            }
        }
    }
}

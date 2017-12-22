using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairMovement : MonoBehaviour {

<<<<<<< HEAD
    private Rigidbody rb;
=======
    private Rigidbody rb;    
>>>>>>> f68092baa8340bf4025a806c7ef94e99d2bfde5e

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}

<<<<<<< HEAD
=======
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
>>>>>>> f68092baa8340bf4025a806c7ef94e99d2bfde5e

        if (other.transform.tag == "stairDown")
        {
<<<<<<< HEAD
           
        }
        else
        {
            Physics.gravity = new Vector3(0, -10f * 10f, 0);
=======
            Debug.Log("touching stairs");
            if (Input.GetKeyDown(KeyCode.S))
            {
                Debug.Log("apply gravity");
                //if (Vector3.Angle(rigidbody.velocity, other.transform.forward) < 90)
               // {
                    rb.AddForce(0, -90, 0);
                //}
            }
>>>>>>> f68092baa8340bf4025a806c7ef94e99d2bfde5e
        }
    }
}

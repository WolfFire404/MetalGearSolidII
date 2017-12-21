using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairMovement : MonoBehaviour {

    private Rigidbody rigidbody;    

	// Use this for initialization
	void Start () {
        rigidbody = GetComponent<Rigidbody>();
	}

    void OnTriggerStay(Collider other)
    {
        if (other.transform.tag == "StairUp")
        {
            if (Vector3.Angle(rigidbody.velocity, other.transform.forward) < 90)
            {
                if (rigidbody.velocity.y > 0)
                {
                    float ypos = rigidbody.velocity.y;
                    ypos = 0;
                }
            }
        }

        if (other.transform.tag == "stairDown")
        {
            Debug.Log("touching stairs");
            if (Input.GetKeyDown(KeyCode.S))
            {
                Debug.Log("apply gravity");
                //if (Vector3.Angle(rigidbody.velocity, other.transform.forward) < 90)
               // {
                    rigidbody.AddForce(0, -90, 0);
                //}
            }
        }
    }
}

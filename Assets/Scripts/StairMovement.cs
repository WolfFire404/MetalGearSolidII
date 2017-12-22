using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairMovement : MonoBehaviour {

    private Rigidbody rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}

    void OnTriggerStay(Collider other)
    {
        if (other.transform.tag == "stair")
        {
           
        }
        else
        {
            Physics.gravity = new Vector3(0, -10f * 10f, 0);
            Debug.Log("touching stairs");
        }
    }
}

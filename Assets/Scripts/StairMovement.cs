using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairMovement : MonoBehaviour {

    private Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}


    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Stairs")
        {
           
        }
        else
        {
            Physics.gravity = new Vector3(0, -10f * 10f, 0);
        }
    }
}

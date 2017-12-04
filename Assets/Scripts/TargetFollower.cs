using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetFollower : MonoBehaviour 
{
	public GameObject Target;


	private Vector3 offset;         


	void Start() 
	{
		offset = transform.position - Target.transform.position;
	}

	void Update() 	
	{
		transform.position = Target.transform.position + offset;
	}
}

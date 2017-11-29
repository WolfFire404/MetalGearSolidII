using UnityEngine;
using System.Collections;

public class MinimapCameraBehaviour : MonoBehaviour {

	public GameObject SecondaryPlayerTarget;


	private Vector3 offset;         


	void Start() 
	{
		offset = transform.position - SecondaryPlayerTarget.transform.position;
	}

	void Update() 	
	{
		transform.position = SecondaryPlayerTarget.transform.position + offset;
	}
}
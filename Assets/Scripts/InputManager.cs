﻿using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour {

	public float lookSpeed = 10;
	public float moveSpeed;
	private Vector3 curLoc;
	private Vector3 prevLoc;

	void Update () 
	{
		InputListen();
		transform.rotation = Quaternion.Lerp (transform.rotation, Quaternion.LookRotation(transform.position - prevLoc), Time.fixedDeltaTime * lookSpeed);
	}

	private void InputListen()
	{
		prevLoc = curLoc;
		curLoc = transform.position;

		if(Input.GetKey(KeyCode.A))
			curLoc.x -= 1 * Time.fixedDeltaTime * moveSpeed;
		if(Input.GetKey(KeyCode.D))
			curLoc.x += 1 * Time.fixedDeltaTime * moveSpeed;
		if(Input.GetKey(KeyCode.W))
			curLoc.z += 1 * Time.fixedDeltaTime * moveSpeed; 
		if(Input.GetKey(KeyCode.S))
			curLoc.z -= 1 * Time.fixedDeltaTime * moveSpeed;

		transform.position = curLoc;

	}
}
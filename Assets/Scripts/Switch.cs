using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour 
{
	private MeshRenderer meshRenderer;
	private bool CheckSwitcher = true;

	void Start() 
	{
		meshRenderer = GetComponent<MeshRenderer> ();
		StartCoroutine (Switcher ());
	}
	
	IEnumerator Switcher()
	{
		while (CheckSwitcher) {
			meshRenderer.enabled = !meshRenderer.enabled;
			yield return new WaitForSeconds(0.2f);
		}
	}
}

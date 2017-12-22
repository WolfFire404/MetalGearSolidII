using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour 
{
	private SpriteRenderer spriteRenderer;
	private bool CheckSwitcher = true;

	void Start() 
	{
		spriteRenderer = GetComponent<SpriteRenderer> ();
		StartCoroutine (Switcher ());
	}
	
	IEnumerator Switcher()
	{
		while (CheckSwitcher) {
			spriteRenderer.enabled = !spriteRenderer.enabled;
			yield return new WaitForSeconds(0.2f);
		}
	}
}

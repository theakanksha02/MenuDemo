using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCloseAnimator : MonoBehaviour {
	Animator anim;
	// Use this for initialization

	void Start()
	{
		anim = GetComponent<Animator> ();
		anim.enabled = false;
	}

	public void opendoor()
	{
		anim.enabled = true;
		anim.SetTrigger ("IsOpen");
	}
}

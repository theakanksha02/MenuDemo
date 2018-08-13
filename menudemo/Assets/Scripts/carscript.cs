using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carscript : MonoBehaviour {

	float rotSpeed= 50.0f;


	void OnMouseDrag()
	{
		transform.Rotate(Vector3.up * Time.deltaTime*rotSpeed, Space.World);
	}
	// Use this for initialization

	
	// Update is called once per frame

}

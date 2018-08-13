using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColorScript : MonoBehaviour {

     Color bronzecolor;
	Color navyblue;
	Color white;
	Color grey;
	Color magenta;

	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ChangeBronze()
	{
		
		if ( ColorUtility.TryParseHtmlString("#72642c", out bronzecolor))
			gameObject.GetComponent<Renderer> ().material.color = bronzecolor;
	}

	public void ChangeNavyBlue()
	{
		if ( ColorUtility.TryParseHtmlString("#2a2f47", out navyblue))
			gameObject.GetComponent<Renderer> ().material.color = navyblue;
	}



	public void ChangeWhite()
	{
		if ( ColorUtility.TryParseHtmlString("#eaf2f0", out white))
			gameObject.GetComponent<Renderer> ().material.color = white;
	}

	public void ChangeGrey()
	{
		if ( ColorUtility.TryParseHtmlString("#2f3133", out grey))
			gameObject.GetComponent<Renderer> ().material.color = grey;
	}

	public void ChangeMagenta()
	{
		if ( ColorUtility.TryParseHtmlString("#30040a", out magenta))
			gameObject.GetComponent<Renderer> ().material.color = magenta;
	}
}

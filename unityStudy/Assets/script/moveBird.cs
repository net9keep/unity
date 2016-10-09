﻿using UnityEngine;
using System.Collections;

public class MoveBird : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	void OnTriggerEnter2D(Collider2D col)
	{
		Debug.Log ("Bird");
		if (col.gameObject.tag == "wall")
			Debug.Log ("Bird crash the wall");
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.UpArrow) == true)
			transform.Translate (Vector3.up * 0.2f);
		else
			transform.Translate (Vector3.down * 0.2f);
	}
}

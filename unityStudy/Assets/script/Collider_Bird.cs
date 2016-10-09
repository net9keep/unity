using UnityEngine;
using System.Collections;

public class Collider_Bird : MonoBehaviour {

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
	
	}
}

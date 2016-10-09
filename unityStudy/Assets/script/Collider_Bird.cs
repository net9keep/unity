using UnityEngine;
using System.Collections;

public class Collider_Bird : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	void OnTriggerEnter2D(Collider2D col)
	{
		
		if (col.transform.tag == "wall")
			Debug.Log ("crash");
		else if (col.transform.tag == "empty_wall") {
			singleton.getInstance.score += 10;
			Debug.Log (singleton.getInstance.score);
		}
	}

	// Update is called once per frame
	void Update () {
	
	}
}

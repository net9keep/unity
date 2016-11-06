using UnityEngine;
using System.Collections;

public class Collider_Wall : MonoBehaviour {
	public int chk = 0;
	// Use this for initialization
	void Start () {
	
	}
	void OnTriggerEnter2D(Collider2D col)
	{
		if (chk != 1) {
			if (col.transform.tag == "bird") {
				Debug.Log ("crash");
				singleton.getInstance.chk = 1;
			}
		}
	}
	// Update is called once per frame
	void Update () {
	
	}
}

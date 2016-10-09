using UnityEngine;
using System.Collections;

public class Collider_EmptyWall : MonoBehaviour {
	public int chk = 0;
	// Use this for initialization
	void Start () {
	
	}
	void OnTriggerEnter2D(Collider2D col)
	{
		if (chk == 0) {
			if (col.transform.tag == "bird") {
				chk = 1;
				singleton.getInstance.score += 10;
				Debug.Log (singleton.getInstance.score);
			}
		}
	}
	// Update is called once per frame
	void Update () {
	
	}
}

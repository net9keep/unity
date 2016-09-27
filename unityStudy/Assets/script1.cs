using UnityEngine;
using System.Collections;

public class script1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		transform.position = new Vector3 (0.0f,0.0f,0.0f);
	}
	
	// Update is called once per frame
	void Update () {
		float speed = 0.1f;
		transform.Translate (Vector3.left*speed);
	}
}

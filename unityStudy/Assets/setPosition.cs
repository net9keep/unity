using UnityEngine;
using System.Collections;

public class setPosition : MonoBehaviour {

	// Use this for initialization
	void Start () {
		this.transform.position = new Vector3 (0, Random.Range(-10.0f,10.0f), 0);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

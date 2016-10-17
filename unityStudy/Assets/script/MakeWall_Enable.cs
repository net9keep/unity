using UnityEngine;
using System.Collections;

public class MakeWall_Enable : MonoBehaviour {
	public GameObject prefab;
	// Use this for initialization
	void Start () {
		for(int i=0; i<5;i++){
			Instantiate (prefab, new Vector3 (0, Random.Range (-10.0f, 10.0f), 0), Quaternion.identity);
			prefab.SetActive (false);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

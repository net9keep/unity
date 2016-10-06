using UnityEngine;
using System.Collections;

public class makeWall_Prefab : MonoBehaviour {
	public GameObject prefab;
	float time = 1.0f;
	float CTime = 0;
	float AddTime = 1.0f;
	// Use this for initialization
	void Start () {
		
	}

	
	// Update is called once per frame
	void Update () {
		if (Time.time > CTime) {
			StartCoroutine ("makePrefab", time);
			CTime = Time.time + AddTime;
		}

	}
	IEnumerator makePrefab(float times){
		yield return new WaitForSeconds (times);
		Instantiate(prefab, new Vector3(0,Random.Range(-10.0f,10.0f),0),Quaternion.identity);
	}
}

using UnityEngine;
using System.Collections;


public class script1 : MonoBehaviour {
	int count = 0;
	// Use this for initialization
	void Start () {
		transform.position = new Vector3 (0.0f,0.0f,0.0f);
	}
	
	// Update is called once per frame
	void Update () {
//		if (count == 100) {
//			Destroy(gameObject); // gameObject = 2d,3d object
//		} else {
//			float speed = 0.1f;
//			transform.Translate (Vector3.left * speed);
//			count++;
//		}
		StartCoroutine("Coroutine",2.0f);
		float speed = 0.1f;
		transform.Translate (Vector3.left * speed);

	}
	IEnumerator Coroutine(float time){
		yield return  new WaitForSeconds (time);
		Destroy (gameObject);
	}
}

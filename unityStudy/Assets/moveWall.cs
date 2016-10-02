using UnityEngine;
using System.Collections;


public class moveWall : MonoBehaviour {
	// Use this for initialization
	void Start () {
		transform.position = new Vector3 (0.0f,Random.Range(-10.0f,10.0f),0.0f);
		StartCoroutine ("Coroutine", 1.5f);
	}
	
	// Update is called once per frame
	void Update () {
		
		float speed = 0.1f;
		transform.Translate (Vector3.left * speed);

	}
	IEnumerator Coroutine(float time){
		yield return  new WaitForSeconds (time);
		singleton.Instance.score += 10;
		Debug.Log (singleton.Instance.score);
		Destroy (gameObject);
	}
}

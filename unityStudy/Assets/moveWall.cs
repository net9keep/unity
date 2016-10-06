using UnityEngine;
using System.Collections;


public class moveWall : MonoBehaviour {
	public Transform up,down;
	// Use this for initialization
	void Start () {
		float yPosition = Random.Range (5f, 10f);
		up.position = new Vector3 (0, yPosition, 0);
		down.position = new Vector3 (0, -yPosition, 0);
		StartCoroutine ("Coroutine", 1.5f);
	}
	
	// Update is called once per frame
	void Update () {
		float speed = 0.1f;
		transform.Translate (Vector3.left * speed);
	}
	IEnumerator Coroutine(float time){
		yield return  new WaitForSeconds (time);
		singleton.getInstance.score += 10;
		Debug.Log (singleton.getInstance.score);
		Destroy (gameObject);
	}
}

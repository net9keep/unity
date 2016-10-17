using UnityEngine;
using System.Collections;


public class moveWall : MonoBehaviour {
	public Transform up,down,empty_wall;
	public Vector3 emptyWall;
	// Use this for initialization
	void Start () {
		setTransformPosition ();
		float yPosition = Random.Range (5f, 7f);
		up.position = new Vector3 (5, yPosition, 0);
		down.position = new Vector3 (5, -yPosition, 0);
		emptyWall = empty_wall.localScale;
		emptyWall.y = 2 * yPosition;
		empty_wall.position = new Vector3 (5, 0, 0);
		StartCoroutine ("Coroutine", 2.0f);
	}
	// Update is called once per frame
	void Update () {
		float speed = 0.1f;
		transform.Translate (Vector3.left * Time.time * speed);
	}
	IEnumerator Coroutine(float time){
		while (true) {
			yield return  new WaitForSeconds (time);
			setTransformPosition ();
		}
	}
	void setTransformPosition(){
		transform.position = new Vector3 (5, 0, 0);
	}
}

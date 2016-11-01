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
		empty_wall.position = new Vector3 (20, 0, 0);
	}
	// Update is called once per frame
	void Update () {
		float speed = 0.01f;
		transform.Translate (Vector3.left * Time.time * speed);
		Vector3 TransPos = transform.position;
		if (TransPos.x <= -20.0)
			setTransformPosition ();
	}
	IEnumerator Coroutine(float time){
		while (true) {
			yield return  new WaitForSeconds (time);
			setTransformPosition ();
		}
	}
	void setTransformPosition(){
		transform.position = new Vector3 (20, 0, 0);
	}
}

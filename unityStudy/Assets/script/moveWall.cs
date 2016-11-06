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
	}
	void Awake(){
		setTransformPosition ();
	}
	void OnDisable()
	{
		setTransformPosition ();
	}
	// Update is called once per frame
	void Update () {
		float speed = 5.0f;
		Vector3 TransPos = transform.position;
		transform.position = Vector3.MoveTowards(transform.position, transform.position + -1*TransPos, speed * Time.deltaTime);
	}
	void setTransformPosition(){
		transform.position = new Vector3 (40, 0, 0);
	}
}

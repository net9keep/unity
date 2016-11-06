using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MakeWall_Enable : MonoBehaviour {
		// Use this for initialization
	int count = 30;
	private int sec = 1;
	public GameObject prefab;
	List<GameObject> wallList = new List<GameObject>();
	void Start () {
		for(int i=0; i<count;i++){
			GameObject wall = (GameObject)Instantiate(prefab, new Vector3 (0, Random.Range (-10.0f, 10.0f), 0), Quaternion.identity);
			wall.SetActive (false);
			wallList.Add (wall.gameObject);
		}
		StartCoroutine (Controll());
	}
				// Update is called once per frame
	void Update () {
			}
	IEnumerator Controll(){
		WaitForSeconds waitSec = new WaitForSeconds(sec);

		int i = 0;

		while(true)
		{
			yield return waitSec;
			activeWall(i % count);
			inactiveWall((i - 6) % count);
			i++;
		}
	}

	private void activeWall(int i)
	{
		wallList[i].SetActive(true);
	}

	private void inactiveWall(int i)
	{
		if(i >= 0)
			wallList[i].SetActive(false);
	}
}
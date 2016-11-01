	using UnityEngine;
	using System.Collections;
	using System.Collections.Generic;

	public class MakeWall_Enable : MonoBehaviour {
		// Use this for initialization
		public GameObject prefab;
		List<GameObject> wallList = new List<GameObject>();
		void Start () {
			for(int i=0; i<5;i++){
				Instantiate(prefab, new Vector3 (0, Random.Range (-10.0f, 10.0f), 0), Quaternion.identity);
				wallList.Add (prefab.gameObject);
				prefab.SetActive (false);
			}

		}
		
		// Update is called once per frame
		void Update () {
		
		}
	}

using UnityEngine;
using System.Collections;

public class GameControll : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
	void OnGUI(){
		GUIStyle style = new GUIStyle();
		style.fontSize = 30;
		style.alignment = TextAnchor.MiddleCenter;
		GUI.Label(new Rect(10, 12, 100, 10), "점수:" + singleton.getInstance.score, style);
	}
	public void Crush(){
		
	}
}


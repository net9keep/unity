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
		if (singleton.getInstance.chk == 0)
			GUI.Label (new Rect (10, 12, 100, 10), "점수:" + singleton.getInstance.score, style);
		else {
			style.fontSize = 100;
			if (singleton.getInstance.score >= GetData ()){
				GUI.Label (new Rect (750, 350, 100, 10), "new High Score:" + singleton.getInstance.score, style);
				SaveData ();
			}
			else if(singleton.getInstance.score < GetData())
				GUI.Label (new Rect (750, 350, 100, 10), "High Score:" + GetData(), style);
			if (GUI.Button (new Rect (600, 450, 400, 100), "재시도")) {
				singleton.getInstance.chk = 0; 
				singleton.getInstance.score = 0;
				int number = UnityEngine.SceneManagement.SceneManager.GetActiveScene ().buildIndex;
				UnityEngine.SceneManagement.SceneManager.LoadScene (number,UnityEngine.SceneManagement.LoadSceneMode.Single);
			}
		}
	}
	void SaveData(){
		PlayerPrefs.SetInt("Score", singleton.getInstance.score);
	}
	int GetData(){
		return PlayerPrefs.GetInt ("Score");
	}
	public void Crush(){
		
	}
}


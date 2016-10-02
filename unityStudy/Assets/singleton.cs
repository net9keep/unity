using UnityEngine;
using System.Collections;

public class singleton{
	private static singleton instance = null;

	public static singleton Instance {
		get {
			if (instance == null)
				instance = new singleton ();
			return instance;
		}
	}
	private singleton(){
	}
	public int score = 0;
}

using UnityEngine;
using System.Collections;

public class singleton{
	private static singleton instance = null;

	public static singleton getInstance {
		get {
			if (instance == null) {
				instance = new singleton ();
			}
			return instance;
		}
	}
	public int wall_count = 0;
	public int score = 0;
	public int chk = 0;
}

using UnityEngine;
using System.Collections;

public class Script : MonoBehaviour {
	private static int BigSize = 50000;
	private static int[,] map=new int[,]{{BigSize,3,2,BigSize,BigSize},
		{BigSize,BigSize,2,4,BigSize},
		{BigSize,BigSize,BigSize,1,3},
		{BigSize,BigSize,BigSize,BigSize,4},
		{BigSize,BigSize,BigSize,BigSize,BigSize}};
	private static int[] dist=new int[]{BigSize,BigSize,BigSize,BigSize,BigSize};
	private static int[] prev=new int[]{-1,-1,-1,-1,-1};
	// Use this for initialization
	void Start () {
		serch (0, 3);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	private static void serch(int start, int end){
		if(start>5 || end>5)
			Debug.Log("error");
		dist[start]=0; // start initialization
		for(int i=0; i<5; i++){
			for(int j=0; j<5; j++){
				if(map[i,j]!=BigSize){
					if(dist[j]==BigSize){
						dist[j]=dist[i]+map[i,j];
						prev[j]=i;
					}
					else if(dist[j] > dist[i]+map[i,j]){
						dist[j]=dist[i]+map[i,j];
						prev[j]=i;
					}
				}
			}
		}
		Debug.Log("length:"+dist[end]);
		trck(start,end);
	}
	private static int trck(int start,int tmp){
		if(tmp==start){
			Debug.Log(start);
		}else{
			Debug.Log(tmp+"->");
			return trck(start,prev[tmp]);
		}
		return 0;

	}
}

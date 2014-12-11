using UnityEngine;
using System.Collections;

public class Interface : MonoBehaviour {

	public static int saved=0;
	public static int dead=0;
	public static int total=0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI(){
		GUI.contentColor = Color.black;
		GUI.Label (new Rect (0, 0, 150, 50), "Humans in total: ");
		GUI.Label (new Rect (0, 15, 150, 50), "Saved humans: ");
		GUI.Label (new Rect (0, 30, 150, 50), "Dead humans: ");
		GUI.contentColor = Color.red;
		GUI.Label (new Rect (140, 0, 200, 50), "" + total);
		GUI.Label (new Rect (140, 15, 200, 50), ""+saved);
		GUI.Label (new Rect (140, 30, 200, 50), ""+dead);
	}
}

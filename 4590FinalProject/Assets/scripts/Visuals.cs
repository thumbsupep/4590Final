using UnityEngine;
using System.Collections;

public class Visuals : MonoBehaviour {

	float width, height;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){
		width = Screen.width * .4f;
		height = Screen.height * .3f;
		GUI.Box(new Rect(Screen.width-width,0,width,height), "");
	}
}

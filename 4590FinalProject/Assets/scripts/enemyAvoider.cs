using UnityEngine;
using System.Collections;

public class enemyAvoider : MonoBehaviour {

	// Use this for initialization
	Vector3 prevPos,currPos;
	float initialPitch, ambientVol, lowerVol;
	
	void Start () {
		initialPitch = audio.pitch;
		ambientVol = GameObject.FindWithTag("ambient").audio.volume;
		lowerVol = GameObject.FindWithTag("ambient").audio.volume - 0.5F;
		currPos = this.transform.position;
		audio.Play();
	}
	
	// Update is called once per frame
	void Update () {
		currPos = this.transform.position;
		if(Input.GetKeyDown(KeyCode.E))
		{
			GameObject.FindWithTag("ambient").audio.volume = lowerVol;
			audio.mute = !audio.mute;
			if(audio.mute == true)
				GameObject.FindWithTag("ambient").audio.volume = ambientVol;
		}
		
		if(Vector3.Distance (currPos, GameObject.FindWithTag("Player").transform.position) < 5 )
		{
			audio.pitch = initialPitch + 0.7F;
		}
		else if((Vector3.Distance (currPos, GameObject.FindWithTag("Player").transform.position)) < 15 )
		{
			audio.pitch = initialPitch + 0.3F;
		}
		else if((Vector3.Distance (currPos, GameObject.FindWithTag("Player").transform.position)) < 10 )
		{
			audio.pitch = initialPitch + 0.5F;
		}
		else if((Vector3.Distance (currPos, GameObject.FindWithTag("Player").transform.position)) > 20 )
		{
			audio.pitch = initialPitch;
		}
	}
}

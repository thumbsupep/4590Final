using UnityEngine;
using System.Collections;

public class friendFinder : MonoBehaviour {


	Vector3 prevPos,currPos;
	float initialPitch, ambientVol;

	void Start () {
		initialPitch = audio.pitch;
		ambientVol = GameObject.FindWithTag("ambient").audio.volume;
		currPos = this.transform.position;
		audio.Play();
	}
	
	// Update is called once per frame
	void Update () {
		currPos = this.transform.position;
		if(Input.GetKeyDown(KeyCode.E))
		{
			GameObject.FindWithTag("ambient").audio.volume -= 0.15F;
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

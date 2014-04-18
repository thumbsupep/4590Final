using UnityEngine;
using System.Collections;

public class friendFinder : MonoBehaviour {


	Vector3 prevPos,currPos;
	float initialPitch, ambientVol, lowerVol;
	int fr;

	void Start () {
		fr = 0;
		initialPitch = audio.pitch;
		ambientVol = GameObject.FindWithTag("ambient").audio.volume;
		lowerVol = GameObject.FindWithTag("ambient").audio.volume - 0.5F;
		currPos = this.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		currPos = this.transform.position;

		if(Input.GetKeyDown(KeyCode.R))
		{
			if(fr < 2)
			{
				fr++;
				GameObject.FindWithTag("ambient").audio.volume = lowerVol;
			}
			else
			{
				fr=0;
				GameObject.FindWithTag("ambient").audio.volume = ambientVol;
			}
		}

		if(fr==1)
			currPos = GameObject.Find("friend1").transform.position;
		else
			currPos = GameObject.Find("friend1").transform.position;

		if((Vector3.Distance (currPos, GameObject.FindWithTag("Player").transform.position)) < 15 )
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

		if(fr==1)
		{
			pointAt.target = GameObject.Find("friend1").transform;
			GameObject.Find("Top").renderer.enabled = true;
			GameObject.Find("Back").renderer.enabled = true;
			GameObject.Find("Bottom").renderer.enabled = true;
			GameObject.Find("Front").renderer.enabled = true;
			GameObject.Find("Left").renderer.enabled = true;
			GameObject.Find("Right").renderer.enabled = true;
			GameObject.Find("friend1").audio.Play();
		}
		else if(fr==2)
		{
			GameObject.Find("Top").renderer.enabled = true;
			GameObject.Find("Back").renderer.enabled = true;
			GameObject.Find("Bottom").renderer.enabled = true;
			GameObject.Find("Front").renderer.enabled = true;
			GameObject.Find("Left").renderer.enabled = true;
			GameObject.Find("Right").renderer.enabled = true;
			pointAt.target = GameObject.Find("friend2").transform;
			GameObject.Find("friend2").audio.Play();
		}
		else if(fr==0)
		{
			GameObject.Find("Top").renderer.enabled = false;
			GameObject.Find("Back").renderer.enabled = false;
			GameObject.Find("Bottom").renderer.enabled = false;
			GameObject.Find("Front").renderer.enabled = false;
			GameObject.Find("Left").renderer.enabled = false;
			GameObject.Find("Right").renderer.enabled = false;
			GameObject.Find("friend1").audio.Stop();
			GameObject.Find("friend2").audio.Stop();
		}

	}
}

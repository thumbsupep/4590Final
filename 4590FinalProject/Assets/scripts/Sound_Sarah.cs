using UnityEngine;
using System.Collections;

public class Sound_Sarah : MonoBehaviour {
	private GameObject SoundEmitter;
	public AudioClip aclip1;
	public AudioClip aclip2;
	public AudioClip aclip3;
	public AudioClip aclip4;
	public AudioClip aclip5;
	public AudioClip aclip6;
	private AudioClip aclip;

	void Start () {
	}
	
	void Update () {

		SoundEmitter = GameObject.Find("Temp_Sound_Emitter_Sarah");
		AudioSource asource = SoundEmitter.GetComponent<AudioSource>();
		if(!asource.isPlaying){
			if(Input.GetKey(KeyCode.Alpha1)){
				aclip = aclip1;
				asource.volume = 1;
				asource.clip = aclip;
				asource.loop = false;
				asource.Play();
			}
			if(Input.GetKey(KeyCode.Alpha2)){
				aclip = aclip2;
				asource.volume = 1;
				asource.clip = aclip;
				asource.loop = false;
				asource.Play();
			}
			if(Input.GetKey(KeyCode.Alpha3)){
				aclip = aclip3;
				asource.volume = 1;
				asource.clip = aclip;
				asource.loop = false;
				asource.Play();
			}
			if(Input.GetKey(KeyCode.Alpha4)){
				aclip = aclip4;
				asource.volume = 1;
				asource.clip = aclip;
				asource.loop = false;
				asource.Play();
			}
			if(Input.GetKey(KeyCode.Alpha5)){
				aclip = aclip5;
				asource.volume = 1;
				asource.clip = aclip;
				asource.loop = false;
				asource.Play();
			}
			if(Input.GetKey(KeyCode.Alpha6)){
				aclip = aclip6;
				asource.volume = 1;
				asource.clip = aclip;
				asource.loop = false;
				asource.Play();
			}
			/*
			asource.clip = aclip;
			asource.loop = false;
			asource.Play();
			*/
		}
	}
}

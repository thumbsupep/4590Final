using UnityEngine;
using System.Collections;

public class Sound_Sarah : MonoBehaviour {
	private GameObject SoundEmitter;
	public AudioClip birdsChirping;
	public AudioClip lightRain;
	public AudioClip mediumRain;
	public AudioClip heavyRain;
	public AudioClip thunderLong;
	public AudioClip thunderDeep;
	public AudioClip lightningBolt;
	public AudioClip hurricaneWind;
	public AudioClip alarmSound;
	private AudioClip aclip;
	private AudioClip newClip;
	private float newVol;
	private AudioSource asourceNew;
	private AudioSource asource;
	public float duration;

	void Start () {
		duration = 2.0f;
		SoundEmitter = GameObject.Find("Temp_Sound_Emitter_Sarah");
		asource = SoundEmitter.GetComponent<AudioSource>();
		asourceNew = SoundEmitter.AddComponent<AudioSource>();
	}
	
	void Update () {
		if(Input.GetKey(KeyCode.Alpha1)){
			newClip = birdsChirping;
			newVol = 0.13f;
			print(asource.clip + " " + asource.volume + " " + newClip + " " + newVol);
			fade(asource.clip, asource.volume, newClip, newVol);
			if(asource.isPlaying){
				print("a"+ asource.clip);
				asource.Stop();
			}
			if(asourceNew.isPlaying){
				print("b" + asourceNew.clip);
				asourceNew.Stop();
			}
			aclip = newClip;
			asource.volume = newVol;
			asource.clip = newClip;
			asource.loop = true;
			asource.Play();
		}
		if(Input.GetKey(KeyCode.Alpha2)){
			newClip = lightRain;
			newVol = 0.18f;
			print(asource.clip + " " + asource.volume + " " + newClip + " " + newVol);
			fade(asource.clip, asource.volume, newClip, newVol);
			if(asource.isPlaying){
				print("a"+ asource.clip);
				asource.Stop();
			}
			if(asourceNew.isPlaying){
				print("b" + asourceNew.clip);
				asourceNew.Stop();
			}
			aclip = newClip;
			asource.volume = newVol;
			asource.clip = newClip;
			asource.loop = true;
			asource.Play();
		}
		if(Input.GetKey(KeyCode.Alpha3)){
			newClip = mediumRain;
			newVol = 0.57f;
			print(asource.clip + " " + asource.volume + " " + newClip + " " + newVol);
			fade(asource.clip, asource.volume, newClip, newVol);
			if(asource.isPlaying){
				print("a"+ asource.clip);
				asource.Stop();
			}
			if(asourceNew.isPlaying){
				print("b" + asourceNew.clip);
				asourceNew.Stop();
			}
			aclip = newClip;
			asource.volume = newVol;
			asource.clip = newClip;
			asource.loop = true;
			asource.Play();
		}
		if(Input.GetKey(KeyCode.Alpha4)){
			newClip = heavyRain;
			newVol = 0.21f;
			print(asource.clip + " " + asource.volume + " " + newClip + " " + newVol);
			fade(asource.clip, asource.volume, newClip, newVol);
			if(asource.isPlaying){
				print("a"+ asource.clip);
				asource.Stop();
			}
			if(asourceNew.isPlaying){
				print("b" + asourceNew.clip);
				asourceNew.Stop();
			}
			aclip = newClip;
			asource.volume = newVol;
			asource.clip = newClip;
			asource.loop = true;
			asource.Play();
		}
		if(Input.GetKey(KeyCode.Alpha5)){
			newClip = thunderLong;
			newVol = 0.7f;
			print(asource.clip + " " + asource.volume + " " + newClip + " " + newVol);
			fade(asource.clip, asource.volume, newClip, newVol);
			if(asource.isPlaying){
				print("a"+ asource.clip);
				asource.Stop();
			}
			if(asourceNew.isPlaying){
				print("b" + asourceNew.clip);
				asourceNew.Stop();
			}
			aclip = newClip;
			asource.volume = newVol;
			asource.clip = newClip;
			asource.loop = true;
			asource.Play();
		}
		if(Input.GetKey(KeyCode.Alpha6)){
			newClip = thunderDeep;
			newVol = 0.87f;
			print(asource.clip + " " + asource.volume + " " + newClip + " " + newVol);
			fade(asource.clip, asource.volume, newClip, newVol);
			if(asource.isPlaying){
				print("a"+ asource.clip);
				asource.Stop();
			}
			if(asourceNew.isPlaying){
				print("b" + asourceNew.clip);
				asourceNew.Stop();
			}
			aclip = newClip;
			asource.volume = newVol;
			asource.clip = newClip;
			asource.loop = true;
			asource.Play();
		}
		if(Input.GetKey(KeyCode.Alpha7)){
			newClip = lightningBolt;
			newVol = 0.53f;
			print(asource.clip + " " + asource.volume + " " + newClip + " " + newVol);
			fade(asource.clip, asource.volume, newClip, newVol);
			if(asource.isPlaying){
				print("a"+ asource.clip);
				asource.Stop();
			}
			if(asourceNew.isPlaying){
				print("b" + asourceNew.clip);
				asourceNew.Stop();
			}
			aclip = newClip;
			asource.volume = newVol;
			asource.clip = newClip;
			asource.loop = true;
			asource.Play();
		}
		if(Input.GetKey(KeyCode.Alpha8)){
			newClip = hurricaneWind;
			newVol = 0.2f;
			print(asource.clip + " " + asource.volume + " " + newClip + " " + newVol);
			fade(asource.clip, asource.volume, newClip, newVol);
			if(asource.isPlaying){
				print("a"+ asource.clip);
				asource.Stop();
			}
			if(asourceNew.isPlaying){
				print("b" + asourceNew.clip);
				asourceNew.Stop();
			}
			aclip = newClip;
			asource.volume = newVol;
			asource.clip = newClip;
			asource.loop = true;
			asource.Play();
		}
		if(Input.GetKey(KeyCode.Alpha9)){
			newClip = alarmSound;
			newVol = 1.0f;
			print(asource.clip + " " + asource.volume + " " + newClip + " " + newVol);
			fade(asource.clip, asource.volume, newClip, newVol);
			if(asource.isPlaying){
				print("a"+ asource.clip);
				asource.Stop();
			}
			if(asourceNew.isPlaying){
				print("b" + asourceNew.clip);
				asourceNew.Stop();
			}
			aclip = newClip;
			asource.volume = newVol;
			asource.clip = newClip;
			asource.loop = true;
			asource.Play();
		}
		/*
		print(asource.clip + " " + asource.volume + " " + newClip + " " + newVol);
		fade(asource.clip, asource.volume, newClip, newVol);
		if(asource.isPlaying){
			print("a"+ asource.clip);
			asource.Stop();
		}
		if(asourceNew.isPlaying){
			print("b" + asourceNew.clip);
			asourceNew.Stop();
		}
		aclip = newClip;
		asource.volume = newVol;
		asource.clip = newClip;
		asource.loop = true;
		asource.Play();*/
	}


	void fade(AudioClip aclipCur, float volCur, AudioClip aclipNew, float volNew){
		asourceNew.clip = aclipNew;
		asourceNew.volume = volNew;

		float j = 0;
		for( float i = volCur; i>0; i-=0.01f){
			j+=0.01f;
			asource.volume = i;
			if(j<=volNew){asourceNew.volume = j;}
		}
		while(asourceNew.volume <= volNew){
			asourceNew.volume += 0.01f;
		}

		asource.volume = 0;
		asourceNew.volume = volNew;

		/*
		if(aclipCur == null){
			//just fade in aclipB part
			float tNew = 0;
			while(tNew < volNew){
				float tempVolNew = asourceNew.volume;
				tNew = tNew + Time.deltaTime / duration;
				asourceNew.volume = tempVolNew * tNew;
			}
		}else{
			float tNew = 0;
			float t = 0;
			while(tNew < volNew || t > 0){
				if(tNew < volNew){
					//float tempVolNew = asourceNew.volume;
					tNew = Mathf.Clamp01(tNew + Time.deltaTime / duration);
					asourceNew.volume = tNew;
				}
				if(t > 0){
					//float tempVol = asource.volume;
					t = Mathf.Clamp01(t + Time.deltaTime / duration);
					asource.volume = volCur - t;
				}
			}*/
			/*
			if(volCur == null){volCur = 0;}
			float startTime = Time.time;
			float endTime = startTime + duration;

			if(volCur == null){volCur = 0;}
			while(Time.time < endTime){
				float i = (Time.time - startTime)/duration;
				if(volCur-i >=0){asource.volume = (volCur-i);}
				if(i <= volNew){asourceNew.volume = i;}
				yield return null;
			}
			*/
		//}


	}
}































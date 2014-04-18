using UnityEngine;
using System.Collections;

public class pointAt : MonoBehaviour {

	public static Transform target;
	// Use this for initialization
	void Start () {
		target = GameObject.FindWithTag("friend").transform;
	
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.LookAt(target,Vector3.back);
	
	}
}

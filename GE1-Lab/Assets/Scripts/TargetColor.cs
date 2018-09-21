using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetColor : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
		
		
		gameObject.GetComponent<Renderer> ().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

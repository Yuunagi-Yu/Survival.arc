﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour {
	public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.forward * Time.deltaTime * speed, Space.Self);
	}

	void OnTriggerEnter(Collider col){
		if (col.tag == "Wall") {
			//Destroy (this.gameObject);
			this.gameObject.SetActive(false);
		}
	}
}

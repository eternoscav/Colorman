﻿using UnityEngine;
using System.Collections;

public class DestroyBulletRed : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
		void OnTriggerStay (Collider other){
		if(other.tag == "BulletRed"){
		Destroy(other.gameObject);
	}

	}
}
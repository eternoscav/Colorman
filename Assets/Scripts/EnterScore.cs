﻿using UnityEngine;
using System.Collections;

public class EnterScore : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space)) {
			Application.LoadLevel ("MAPARED");
		}
		
	}
}

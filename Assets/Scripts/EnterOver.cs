﻿using UnityEngine;
using System.Collections;

public class EnterOver : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space)) {
			//GameController gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
			//gc.ChangeLevel("INICIO");
			Application.LoadLevel ("INICIO");
		}
		
	}
}

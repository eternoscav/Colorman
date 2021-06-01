using UnityEngine;
using System.Collections;

public class HabilitarCores : MonoBehaviour { 
	public materialPlataforma rosa1;
	public materialPlataforma rosa2;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
void OnTriggerEnter(Collider other){

		if(other.tag == "Player"){
			rosa1.enabled = true;
			rosa2.enabled = true;
		}
	}
}

using UnityEngine;
using System.Collections;

public class HabilitarPlataforma : MonoBehaviour {
	public PlataformMoviment rosa1;
	public PlataformMoviment rosa2;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other){
		
		
		if(other.tag == "BulletRed" || other.tag == "BulletOrange" ||other.tag == "BulletYellow" || other.tag == "BulletGreen"
			|| other.tag == "BulletBlue" || other.tag == "BulletPink"){
			rosa1.enabled = true;
			rosa2.enabled = true;
		}
	}
}

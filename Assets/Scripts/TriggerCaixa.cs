using UnityEngine;
using System.Collections;

public class TriggerCaixa : MonoBehaviour {

	// Use this for initialization
	void Start () {
	collider.isTrigger = true;
	}
	
	// Update is called once per frame
	void OnTriggerEnter(Collider other){
		
		
		if(other.tag == "Player"){
			other.GetComponent<CharacterMotor>().movement.maxForwardSpeed = 10;
		}
	}
	
	void OnTriggerStay(Collider other){
		
		if(other.tag == "Player"){
			Player p = other.gameObject.GetComponent<Player>();
			p.Empurrar(10);
			
			other.GetComponent<CharacterMotor>().movement.maxForwardSpeed = 3;
		}
	}
}

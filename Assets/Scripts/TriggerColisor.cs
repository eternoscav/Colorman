using UnityEngine;
using System.Collections;

public class TriggerColisor : MonoBehaviour {
	public GameObject caixa;

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
			caixa.rigidbody.constraints &= ~RigidbodyConstraints.FreezePositionX;
			//rigidbody.constraints &= ~RigidbodyConstraints.FreezePositionX;
			other.GetComponent<CharacterMotor>().movement.maxForwardSpeed = 3;
		}
	}
}

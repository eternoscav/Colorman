using UnityEngine;
using System.Collections;

public class TriggerHeroi4 : MonoBehaviour {
	//public Player player;
	public Heroi3 heroi3;
	public Heroi2 heroi2;
	public GameObject colisor5;
	
	


	void Start () {
		
	}
	

	void Update () {
		
	}
	void OnTriggerStay(Collider other){
		if(other.tag == "Player"){
		colisor5.SetActive (true);
		heroi2.enabled = false;
		//player.enabled = false;
		heroi3.enabled = true;
		//Destroy (gameObject);
		}
	}

		}


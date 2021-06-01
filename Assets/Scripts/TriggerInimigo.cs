using UnityEngine;
using System.Collections;

public class TriggerInimigo : MonoBehaviour {
	//public Player player;
	public GameObject Vilao;
	 


	void Start () {
		
	}
	

	void Update () {
		
	}
	void OnTriggerStay(Collider other){
		if(other.tag == "Vilao"){
		//player.enabled = false;
		Vilao.SetActive (false);
		//Destroy (gameObject);
		}
	}

		}


using UnityEngine;
using System.Collections;

public class TriggerHeroi : MonoBehaviour {
	public Player player;
	public GameObject Controls;
	public Heroi heroi;
	public GameObject colisor;
	public GameObject salvar;
	


	void Start () {
		
	}
	

	void Update () {
		
	}
	void OnTriggerExit(Collider other){
		if(other.tag == "Player"){
		player.enabled = false;
		heroi.enabled = true;
		Controls.SetActive (false);
		salvar.SetActive (false);
		//Destroy (gameObject);
		colisor.SetActive (false);
	}
	}

		}


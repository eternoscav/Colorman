using UnityEngine;
using System.Collections;

public class TriggerHeroi5 : MonoBehaviour {
	public GameObject Score;
	public GameObject player;


	
	void OnTriggerStay(Collider other){
		if(other.tag == "Player"){
		player.SetActive (false);
		Score.SetActive(true);
		Application.LoadLevel ("SCORE");
			}
	}

		}


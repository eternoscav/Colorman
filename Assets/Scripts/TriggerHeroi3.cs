using UnityEngine;
using System.Collections;

public class TriggerHeroi3 : MonoBehaviour {
	public Player player;
	public Heroi2 heroi2;
	public AudioCenaVilao2 audio2;
	public AudioCenaVilao3 audio3;
	public CountDown countdown;
	public TesteRandomManual random;
	public GameObject colisor4;
	public GameObject Paineis;
	public GameObject Controls;


	void Start () {
		
	}
	

	void Update () {
		
	}
	void OnTriggerStay(Collider other){
	if(other.tag == "Player"){
			
			countdown.enabled = false;
			audio3.enabled = true;
		random.enabled = false;			
		audio2.Desligar = true;
		audio2.enabled = false;
		StartCoroutine (Super());
			
		player.enabled = false;
		heroi2.enabled = true;
		Paineis.SetActive(false);
		colisor4.SetActive (true);
		Controls.SetActive (false);
		//Destroy (gameObject);
		}
	}
			public IEnumerator Super ()
	{
		yield return new WaitForSeconds(0);
		audio3.Desligar = false;
	}


		}


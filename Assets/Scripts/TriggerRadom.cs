using UnityEngine;
using System.Collections;

public class TriggerRamdom : MonoBehaviour {
	public Player player;
	public GameObject Crystal;
	public GameObject CrystalStone;
	public GameObject PortalAtivo;
	public GameObject ArcoAtivo;
	public GameObject ArcoInativo;
	public GameObject PortalInativo;
	//public GameObject LiberarPorta;
	public GameObject Colisor;
	public faceOrange orange;
	public faceGreen green;
	public faceBlue blue;
	public facePink pink;
	public faceRed red;
	public faceCinza cinza;
	public faceYellow yellow;
	public Player trocaface;
	public int cont=0;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}
	
	void OnTriggerEnter(Collider other){
		//LiberarPorta.SetActive(false);
		//Debug.Log (other.gameObject.name);
		if(other.tag == "Player"){
			Player p = other.gameObject.GetComponent<Player>();
			p.RecolherCrystal(1);
			PortalAtivo.SetActive(true);
			ArcoAtivo.SetActive(true);
			ArcoInativo.SetActive(false);
			Colisor.SetActive (true);
			PortalInativo.SetActive(false);
			Crystal.SetActive(true);
			CrystalStone.SetActive (false);
			
			//Destroy (gameObject);
			if(cont == 0 ){
				red.enabled = true;
				cinza.enabled = false;
				
			}
				if(cont == 1){
				orange.enabled = true;
				red.enabled = false;
				
			}
				if(cont == 2){
				yellow.enabled = true;
				orange.enabled = false;
				
			}
				if(cont == 3){
				green.enabled = true;
				yellow.enabled = false;
				
			}
				if(cont == 4){
				blue.enabled = true;
				green.enabled = false;
				
			}
				if(cont == 5){
				pink.enabled = true;
				blue.enabled = false;
				
			}
				

			
		}

	}
}


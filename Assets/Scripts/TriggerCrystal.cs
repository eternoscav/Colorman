using UnityEngine;
using System.Collections;

public class TriggerCrystal : MonoBehaviour {
	public Player player;
	public GameObject Crystal;
	public GameObject CrystalStone;
	public GameObject ArcoAtivo;
	public GameObject ArcoInativo;
	public GameObject AtivaStar;
	public GameObject DesativaStar;
	public faceOrange orange;
	public faceGreen green;
	public faceBlue blue;
	public facePink pink;
	public faceRed red;
	public faceCinza cinza;
	public faceYellow yellow;
	public Player trocaface;
	public int cont=0;
	public int cont2 = 0;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}
	
	void OnTriggerEnter(Collider other){
		if(other.tag == "Player"){
			Player p = other.gameObject.GetComponent<Player>();
			AtivaStar.SetActive (true);
			DesativaStar.SetActive (false);
			p.RecolherCrystal(1);
			ArcoAtivo.SetActive(true);
			ArcoInativo.SetActive(false);
			Crystal.SetActive(true);
			CrystalStone.SetActive (false);
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
			
			if(cont2 == 1){
				player.p = false;
				player.v = true;
				player.or = false;
				player.ye = false;
				player.gr = false;
				player.bl = false;
				player.pi = false;	
			}
			if( cont2 == 2){
				player.p = false;
				player.v = false;
				player.or = true;
				player.ye = false;
				player.gr = false;
				player.bl = false;
				player.pi = false;
			}
				
				if( cont2 == 3){
				player.p = false;
				player.v = false;
				player.or = false;
				player.ye = true;
				player.gr = false;
				player.bl = false;
				player.pi = false;
			}
				if( cont2 == 4){
				player.p = false;
				player.v = false;
				player.or = false;
				player.ye = false;
				player.gr = true;
				player.bl = false;
				player.pi = false;
			}
				if( cont2 == 5){
				player.p = false;
				player.v = false;
				player.or = false;
				player.ye = false;
				player.gr = false;
				player.bl = true;
				player.pi = false;
			}
				if( cont2 == 6){
				player.p = false;
				player.v = false;
				player.or = false;
				player.ye = false;
				player.gr = false;
				player.bl = false;
				player.pi = true;
			}
				

			
		}

	}
}


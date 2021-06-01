using UnityEngine;
using System.Collections;

public class TrocaPoder : MonoBehaviour {
	public Player magia;
	public int cont = 0;

	 
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerStay(Collider other){

		if(other.tag == "Player"){
			
			if(cont == 1){
				magia.p = false;
				magia.v = true;
				magia.or = false;
				magia.ye = false;
				magia.gr = false;
				magia.bl = false;
				magia.pi = false;	
			}
			if( cont == 2){
				magia.p = false;
				magia.v = false;
				magia.or = true;
				magia.ye = false;
				magia.gr = false;
				magia.bl = false;
				magia.pi = false;
			}
				
				if( cont == 3){
				magia.p = false;
				magia.v = false;
				magia.or = false;
				magia.ye = true;
				magia.gr = false;
				magia.bl = false;
				magia.pi = false;
			}
				if( cont == 4){
				magia.p = false;
				magia.v = false;
				magia.or = false;
				magia.ye = false;
				magia.gr = true;
				magia.bl = false;
				magia.pi = false;
			}
				if( cont == 5){
				magia.p = false;
				magia.v = false;
				magia.or = false;
				magia.ye = false;
				magia.gr = false;
				magia.bl = true;
				magia.pi = false;
			}
				if( cont == 6){
				magia.p = false;
				magia.v = false;
				magia.or = false;
				magia.ye = false;
				magia.gr = false;
				magia.bl = false;
				magia.pi = true;
			}

			//Player p = other.gameObject.GetComponent<Player>();
			//p.RecolherCrystal(1);

			
		}
	}
	}


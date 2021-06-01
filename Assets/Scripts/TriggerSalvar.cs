using UnityEngine;
using System.Collections;

public class TriggerSalvar : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
		void OnTriggerEnter(Collider other){
		if(other.tag == "Player"){
			Player p = other.gameObject.GetComponent<Player>();
			p.NumeroInimigo(1);

		}

	}

}

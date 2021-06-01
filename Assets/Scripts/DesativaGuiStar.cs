using UnityEngine;
using System.Collections;

public class DesativaGuiStar : MonoBehaviour {
	public GameObject Desativar;
	// Use this for initialization
	void Start () {
	 
	}
	
	// Update is called once per frame
	void Update () {
	
	}
		void OnTriggerEnter(Collider other){
		if(other.tag == "Player"){
			Desativar.SetActive(false);
		}
	}
}

using UnityEngine;
using System.Collections;

public class LiberarMagia : MonoBehaviour {
	public GameObject liberarMagiaA;
	public GameObject liberarMagiaI;
	public GameObject liberarJumpA;
	public GameObject liberarJumpI;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other){
		if(other.tag == "Player"){
			liberarMagiaA.SetActive (true);
			liberarMagiaI.SetActive (false);
			liberarJumpA.SetActive(true);
			liberarJumpI.SetActive(false);
		
	}
}
}
using UnityEngine;
using System.Collections;

public class LigarPoder : MonoBehaviour {
	public Player player;
	public GameObject colisor;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
		void OnTriggerEnter(Collider other){
		
		
		if(other.tag == "BulletRed" || other.tag == "BulletOrange" ||other.tag == "BulletYellow" || other.tag == "BulletGreen"
			|| other.tag == "BulletBlue" || other.tag == "BulletPink"){
		player.p = true;
		colisor.SetActive (false);
		
		}
}
}
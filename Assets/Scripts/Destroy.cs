using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
		void OnTriggerStay (Collider other){
		if(other.tag == "bullet" ||  other.tag == "BulletYellow" || other.tag == "BulletRed"  ||  other.tag == "BulletGreen" || 
			other.tag == "BulletBlue" ||  other.tag == "BulletPink" ||  other.tag == "BulletOrange"){
		Destroy(other.gameObject);
	}

	}
}
using UnityEngine;
using System.Collections;

public class TriggerCoracao : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}
	
	void OnTriggerEnter(Collider other){
		//Debug.Log (other.gameObject.name);
		if(other.tag == "Player"){
			Player p = other.gameObject.GetComponent<Player>();
			p.RecolherCoracoes(1);
			Destroy (gameObject);
			
		}

}
}

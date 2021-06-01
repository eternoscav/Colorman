using UnityEngine;
using System.Collections;

public class TriggerPorta2: MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		StartCoroutine (Super());
	
	}
	
	public IEnumerator Super ()
	{

		yield return new WaitForSeconds(3);
		Application.LoadLevel ("MAPACINZA");
	
	}
	//void OnTriggerEnter(Collider other){
//		yield return new WaitForSeconds(3);
		

//			inimigo p = other.gameObject.GetComponent<inimigo>();
//
//			
//			p.MudarFase(1);
			//Destroy (gameObject);
			
			
}
	
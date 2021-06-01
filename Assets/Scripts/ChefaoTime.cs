using UnityEngine;
using System.Collections;

public class ChefaoTime : MonoBehaviour {
	
	public GameObject time;
	public CountDown countDown; 
//	public GameObject ampulhetas;
	
	
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		countDown.enabled = true;
		time.SetActive(true);
	}
	
	//void OnTriggerEnter(Collider other){
		//Debug.Log (other.gameObject.name);
		//if(other.tag == "Player"){
		//	Player p = other.gameObject.GetComponent<Player>();
		//	p.RecolherKey(1);
//			Destroy (gameObject);
		//	gameObject.SetActive(false);
			
			
		//	ampulhetas.SetActive(true);
		//	foreach (Transform t in ampulhetas.transform)
		//	t.gameObject.SetActive(true);
			//porta2.SetActive(true);
		//	portaSecreta.SetActive(true);
			//porta.SetActive(false);
		//}

	}
//}

using UnityEngine;
using System.Collections;
 
public class TriggerPlataforma : MonoBehaviour {
	public Player player;
	public GameObject PlataformaColor;
	public GameObject PlataformaCinza;

	void Start () {
		
	}

	void Update () {
	}

	void OnTriggerEnter(Collider other){

		if(other.tag == "Player"){

			PlataformaColor.SetActive(true);
			PlataformaCinza.SetActive(false);

				

			
		}

	}
}


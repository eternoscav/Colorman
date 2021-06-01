using UnityEngine;
using System.Collections;

public class AudioVilao : MonoBehaviour
	
{

	public GameObject colisor;
	void OnTriggerStay (Collider other)
	{
		if (other.tag == "Player") {
			Player p = other.gameObject.GetComponent<Player> ();
			colisor.SetActive (false);
			p.TriggerVilao (1);

	

		}
	}
		

}


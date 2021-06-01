using UnityEngine;
using System.Collections;

public class TriggerPoder : MonoBehaviour {
	public GameObject colisor;

	
    void Update() {

	
		StartCoroutine (Troca1 ());

		

}
	public IEnumerator Troca1 ()
	{
		
		yield return new WaitForSeconds(3);
		colisor.SetActive(true);

		StartCoroutine (Troca2 ());
	}
	
	public IEnumerator Troca2 ()
	{
		
		yield return new WaitForSeconds(3);
		colisor.SetActive(false);

		StartCoroutine (Troca1 ());
	}
}
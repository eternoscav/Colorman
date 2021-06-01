using UnityEngine;
using System.Collections;

public class TriggerEstrelaChefao : MonoBehaviour {
		public GameObject starA;
		public GameObject starI;
	
	
	void OnTriggerEnter(Collider other){
		if(other.tag == "Player"){
		Player p = other.gameObject.GetComponent<Player>();
		p.RecolherEstrela(1);
		StartCoroutine (color ());
		StartCoroutine (color2 ());
			
			
		}

}
	public IEnumerator color(){
	yield return new WaitForSeconds(1);
	Destroy (gameObject);
		}
	
	public IEnumerator color2(){
	yield return new WaitForSeconds(0);
	starA.SetActive(true);
	starI.SetActive(false);
	yield return new WaitForSeconds(0);
	starI.SetActive(true);
	starA.SetActive(false);
		}
	
}

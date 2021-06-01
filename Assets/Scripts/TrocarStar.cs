using UnityEngine;
using System.Collections;

public class TrocarStar : MonoBehaviour {
	public GameObject color1;
	public GameObject color2;
	public GameObject color3;
	public GameObject color4;
	public GameObject color5;
	public GameObject color6;
	public GameObject colorblue;
	public GameObject colorCinza;
	

	
    void Start() {
		StartCoroutine (Troca1 ());

		

}
	
	void OnTriggerEnter(Collider other){
		if(other.tag == "Player"){
	StartCoroutine (Troca1 ());
		}
	}
	
	public IEnumerator Troca1 ()
	{
		colorblue.SetActive (false);
		colorCinza.SetActive (false);
		color6.SetActive (false);
		color1.SetActive (true);
		yield return new WaitForSeconds(0.1f);
		color1.SetActive (false);
		color2.SetActive (true);
		yield return new WaitForSeconds(0.1f);
		color2.SetActive (false);
		color3.SetActive (true);
		yield return new WaitForSeconds(0.1f);
		color3.SetActive (false);
		color4.SetActive (true);
		yield return new WaitForSeconds(0.1f);
		color4.SetActive (false);
		color5.SetActive (true);
		yield return new WaitForSeconds(0.1f);
		color5.SetActive (false);
		color6.SetActive (true);
		yield return new WaitForSeconds(0.1f);
		StartCoroutine (Troca2 ());
	}
	
		public IEnumerator Troca2 ()
	{
		color6.SetActive (false);
		color1.SetActive (true);
		yield return new WaitForSeconds(0.1f);
		color1.SetActive (false);
		color2.SetActive (true);
		yield return new WaitForSeconds(0.1f);
		color2.SetActive (false);
		color3.SetActive (true);
		yield return new WaitForSeconds(0.1f);
		color3.SetActive (false);
		color4.SetActive (true);
		yield return new WaitForSeconds(0.1f);
		color4.SetActive (false);
		color5.SetActive (true);
		yield return new WaitForSeconds(0.1f);
		color5.SetActive (false);
		color6.SetActive (true);
		yield return new WaitForSeconds(0.1f);
		StartCoroutine (Troca1 ());
	}
	
	
}
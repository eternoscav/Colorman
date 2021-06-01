using UnityEngine;
using System.Collections;

public class Sofrendo : MonoBehaviour {
	//public GameObject ativar;
	

//S public Material MaterialStart ;
	
	void Start () {
		
	}

	void Update ()
	{
		animation.Blend ("sofrendo");
		
		StartCoroutine (Destroy ());
	

	}
		public IEnumerator Destroy (){
		yield return new WaitForSeconds(4);
		//ativar.SetActive (false);
}

}
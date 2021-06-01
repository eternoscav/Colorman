using UnityEngine;
using System.Collections;

public class Idle : MonoBehaviour {
	public GameObject ativar;
	

//S public Material MaterialStart ;
	
	void Start () {
		
	}

	void Update ()
	{
		animation.Blend ("idle");
		
		StartCoroutine (Destroy ());
	

	}
		public IEnumerator Destroy (){
		yield return new WaitForSeconds(4);
		ativar.SetActive (false);
}

}
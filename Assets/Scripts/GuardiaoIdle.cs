using UnityEngine;
using System.Collections;

public class GuardiaoIdle : MonoBehaviour {
	public GameObject guardiao;
	public GameObject star;
	public AudioClip Obrigado;
 	void Update ()
	{
		audio.PlayOneShot (Obrigado);
		//animation.Blend ("idle");
		star.SetActive (true);
		StartCoroutine (Destroy ());

	}
		public IEnumerator Destroy (){
		yield return new WaitForSeconds(3);
		//Destroy(gameObject, 1);
		guardiao.SetActive (false);

}

}



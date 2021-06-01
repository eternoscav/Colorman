using UnityEngine;
using System.Collections;

public class InimigoIdle : MonoBehaviour {
	public Inimigo inimigo;
	public GameObject salvar;
	public GameObject star;
	public GameObject colorido;
    public Material MaterialStart ;
	public Material MaterialEnd ;
	public float duration = 1.0F;
	public AudioClip Obrigado;

	
	
	
	void Start () {
		audio.PlayOneShot (Obrigado);
 		salvar.SetActive (true);
	}

	void Update ()
	{
		
		colorido.renderer.material = MaterialEnd;
		inimigo.enabled = false;
		animation.Stop ("walk");
		animation.Blend ("idle");
		star.SetActive (true);
		
		StartCoroutine (Destroy ());
		StartCoroutine (Destroy2 ());

	}
	public IEnumerator Destroy (){
		yield return new WaitForSeconds(1);
		
		Destroy(gameObject, 1);


}
		public IEnumerator Destroy2 (){
		yield return new WaitForSeconds(2.9f);

}
}

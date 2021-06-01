using UnityEngine;
using System.Collections;

public class materialPainelPlat : MonoBehaviour {
    public Material MaterialStart ;
    public Material MaterialEnd ;
	public GameObject player;
	public float duration = 1.0F;
	public bool v = false;
	public PlataformMoviment plataforma;
	public materialPlataforma material;
	public TrocaCor trocacor;
	//public GameObject Magia;
	public rotacaoPainel painel;
    void Start() {

		player.renderer.material = MaterialStart;
        
    }
		void OnTriggerEnter(Collider other){
		
		
		if(other.tag == "bullet"  ||other.tag == "BulletRed" || other.tag == "BulletOrange" ||other.tag == "BulletYellow" || other.tag == "BulletGreen"
			|| other.tag == "BulletBlue" || other.tag == "BulletPink" && v==false){
				
		float lerp = Mathf.PingPong (Time.time, duration) / duration;
        player.renderer.material.Lerp (MaterialStart, MaterialEnd, lerp);
		player.renderer.material = MaterialEnd;
		
		StartCoroutine (tempo2 ());
		//Magia.SetActive (true);
		painel.enabled = true;
		//collider.isTrigger = false;
		collider.enabled = false;
		v=true;
		StartCoroutine (tempo ());
			
			
		}

}
	
	public IEnumerator tempo(){
		yield return new WaitForSeconds(1);
		painel.enabled = false;
		
	}
		public IEnumerator tempo2(){
		yield return new WaitForSeconds(1);
		trocacor.enabled = true;
		plataforma.enabled = true;
		material.enabled = true;
		
	}
	
		
}
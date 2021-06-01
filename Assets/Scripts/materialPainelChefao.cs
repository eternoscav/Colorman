using UnityEngine;
using System.Collections;

public class materialPainelChefao : MonoBehaviour {
	public materialCaixa material;
    public Material MaterialStart ;
    public Material MaterialEnd ;
	public GameObject player;
	public float duration = 1.0F;
	public bool v = false;
	//public Texture2D ColorLanja;
	//public PlataformMoviment plataforma;
	//public materialPlataforma material;
	//public GameObject Magia;
	public rotacaoPainel painel;
    void Start() {

		player.renderer.material = MaterialStart;
        
    }
		void OnTriggerEnter(Collider other){
		
		
		if(other.tag == "Bulletoutro" && v==false){
			
		float lerp = Mathf.PingPong (Time.time, duration) / duration;
        player.renderer.material.Lerp (MaterialStart, MaterialEnd, lerp);
		player.renderer.material = MaterialEnd;
		
		StartCoroutine (tempo2 ());
		//Magia.SetActive (true);
		//LiberarPorta.SetActive(false);
			
		painel.enabled = true;
		//collider.isTrigger = false;
		//collider.enabled = false;
		v=true;
		StartCoroutine (tempo ());
			
			
		}

}
	
	public IEnumerator tempo(){
		yield return new WaitForSeconds(1);
		painel.enabled = false;
		material.enabled = true;	
		
	}
		public IEnumerator tempo2(){
		yield return new WaitForSeconds(1);
		//plataforma.enabled = true;
		//material.enabled = true;
		
	}
	
		
}
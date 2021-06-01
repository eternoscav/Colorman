using UnityEngine;
using System.Collections;

public class materialPainelChefaoOrange : MonoBehaviour {
	public CountDown countDown;
	public materialCaixa material;
	public materialCaixa2 material2;
	public materialCaixa3 painelOrange;
	public materialCaixa3 material3;
	public TesteRandomManual cont;
    public Material MaterialStart ;
    public Material MaterialEnd ;
	public GameObject player;
	public float duration = 1.0F;
	public bool v = false;
	public GameObject setas;
	public int bonus;
	public rotacaoPainel painel;
    void Start() {

		player.renderer.material = MaterialStart;
        
    }
		void OnTriggerEnter(Collider other){
		
		
		if(other.tag == "BulletOrange" && v==false){
		bonus = 20;
		countDown.timer += bonus;
		setas.SetActive (true);
		foreach (Transform t in setas.transform)
		t.gameObject.SetActive(true);
		painelOrange.enabled = true;
			
		float lerp = Mathf.PingPong (Time.time, duration) / duration;
        player.renderer.material.Lerp (MaterialStart, MaterialEnd, lerp);
		player.renderer.material = MaterialEnd;
		material.enabled = true;
		material2.enabled = false;
		material3.enabled = true;
		StartCoroutine (tempo2 ());
		//Magia.SetActive (true);
		//LiberarPorta.SetActive(false);
			
		painel.enabled = true;
		collider.isTrigger = false;
		//collider.enabled = false;
		//v=true;
		StartCoroutine (tempo ());
			
			
		}

}
	
	public IEnumerator tempo(){
		yield return new WaitForSeconds(1);
		painel.enabled = false;
		material.enabled = true;
		player.SetActive (false);
		
	}
		public IEnumerator tempo2(){
		yield return new WaitForSeconds(1);
		//plataforma.enabled = true;
		material.enabled = true;
		cont.cont++;
	}
	
		
}
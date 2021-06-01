using UnityEngine;
using System.Collections;

public class materialPainelColor : MonoBehaviour {
    public Material MaterialStart ;
    public Material MaterialEnd ;
	public GameObject player;
	public float duration = 1.0F;
	public bool v = false;
	public GameObject LiberarPorta;
	public rotacaoPainel painel;
    void Start() {

		player.renderer.material = MaterialStart;
        
    }
		void OnTriggerEnter(Collider other){
		
		
//		if(other.tag == "bullet"  || other.tag == "BulletRed" || other.tag == "BulletOrange" ||other.tag == "BulletYellow" || other.tag == "BulletGreen"
//			|| other.tag == "BulletBlue" || other.tag == "BulletPink"&& v==false){
//				
//		float lerp = Mathf.PingPong (Time.time, duration) / duration;
//        player.renderer.material.Lerp (MaterialStart, MaterialEnd, lerp);
//		player.renderer.material = MaterialEnd;
//		
//		StartCoroutine (tempo2 ());
//		LiberarPorta.SetActive(false);
//		painel.enabled = true;
//		v=true;
//		StartCoroutine (tempo ());
//			
//			
//		}

}
	
	public IEnumerator tempo(){
		yield return new WaitForSeconds(1);
		painel.enabled = false;
		
	}
		public IEnumerator tempo2(){
		yield return new WaitForSeconds(1);

		
	}
	
		
}
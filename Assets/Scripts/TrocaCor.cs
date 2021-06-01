using UnityEngine;
using System.Collections;

public class TrocaCor : MonoBehaviour {
    public Material faceAtual ;
   // public Material faceFinal ;
	public GameObject player;
	public float duration = 1.0F;
	//public bool isEnabled = false;
	
    void Start() {

		player.renderer.material = faceAtual;
		//StartCoroutine (Troca1 ());
       //	float lerp = Mathf.PingPong (Time.time, duration) / duration;
       // player.renderer.material.Lerp (faceAtual, faceFinal, lerp);
		//player.renderer.material = faceFinal;
		

			
			
		

}
//	public IEnumerator Troca1 ()
//	{
//		
//		yield return new WaitForSeconds(0);
//		player.renderer.material = faceFinal;
//		yield return new WaitForSeconds(0);
//		player.renderer.material = faceAtual;
//		StartCoroutine (Troca2 ());
//	}
//	
//	public IEnumerator Troca2 ()
//	{
//		
//		yield return new WaitForSeconds(2);
//		player.renderer.material = faceAtual;
//		yield return new WaitForSeconds(0);
//		player.renderer.material = faceFinal;
//		StartCoroutine (Troca1 ());
//	}
}
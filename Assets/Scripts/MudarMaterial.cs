using UnityEngine;
using System.Collections;

public class MudarMaterial : MonoBehaviour {
    public Material MaterialStart ;
    public Material MaterialEnd ;
	public GameObject player;
	public float duration = 1.0F;

    void Start() {
	StartCoroutine (Troca ());


	}
		public IEnumerator Troca ()
	{
		yield return new WaitForSeconds(0.5f);
		
					
		player.renderer.material = MaterialStart;
		float lerp = Mathf.PingPong (Time.time, duration) / duration;
        player.renderer.material.Lerp (MaterialStart, MaterialEnd, lerp);
		player.renderer.material = MaterialEnd;
	}
}
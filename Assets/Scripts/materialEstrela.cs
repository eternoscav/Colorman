using UnityEngine;
using System.Collections;

public class materialEstrela : MonoBehaviour {
    public Material MaterialStart ;
    public Material MaterialEnd ;
	public GameObject player;
	public float duration = 1.0F;
    void Start() {

		player.renderer.material = MaterialStart;
        
    }
		void OnTriggerEnter(Collider other){
		if(other.tag == "Player"){
		float lerp = Mathf.PingPong (Time.time, duration) / duration;
        player.renderer.material.Lerp (MaterialStart, MaterialEnd, lerp);
		player.renderer.material = MaterialEnd;
		
		//player.SetActive (false);
		//collider.enabled = false;

			
			
		}

}
}
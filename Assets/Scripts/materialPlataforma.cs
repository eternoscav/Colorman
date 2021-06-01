using UnityEngine;
using System.Collections;

public class materialPlataforma : MonoBehaviour {
    public Material MaterialStart ;
    public Material MaterialEnd ;
	public GameObject player;
	public float duration = 1.0F;
	public GameObject Magia;
    void Start() {

		player.renderer.material = MaterialStart;
				float lerp = Mathf.PingPong (Time.time, duration) / duration;
        player.renderer.material.Lerp (MaterialStart, MaterialEnd, lerp);
		player.renderer.material = MaterialEnd;
		Magia.SetActive (true);
        
    }
		//void OnTriggerEnter(Collider other){
		
		
		//if(other.tag == "Player"){
				


			
			
	//	}

//}
	
		
}
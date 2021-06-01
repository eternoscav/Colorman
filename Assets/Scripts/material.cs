using UnityEngine;
using System.Collections;

public class material : MonoBehaviour {
    public Material MaterialFundo ;
	public Material MaterialPlataforma ;
	public ColorCorrectionCurves color;

	public GameObject fundo;
	public GameObject plataforma;
    	
	

	
    void Update() {
		//renderer.enabled = false;
		//renderer.material = MaterialStart;
		if (Input.GetButtonDown ("Jump")){
			trocarCor();
//    	float lerp = Mathf.PingPong (Time.time, duration) / duration;
//        player.renderer.material.Lerp (MaterialStart, MaterialEnd, lerp);
//		player.renderer.material = MaterialEnd;
		//Magia.SetActive (true);

		}
			
		}
	void trocarCor(){
	fundo.SetActive(true);
    foreach (Transform f in fundo.transform)
	f.gameObject.renderer.material= MaterialFundo;
	plataforma.SetActive(true);
  	plataforma.renderer.material  = MaterialPlataforma;
	color.enabled = true;
	color.saturation = 1;
	//plataforma.renderer.materials = MaterialPlataforma;

	}
}	

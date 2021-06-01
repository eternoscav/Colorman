using UnityEngine;
using System.Collections;

public class faceColor : MonoBehaviour {
    public Material faceCinza ;
    public Material faceRed ;
	public Material faceOrange ;
    public Material faceYellow ;
	public Material faceGreen ;
    public Material faceBlue ;
	public Material facePink ;
	public GameObject player;
	public float duration = 1.0F;
	public InimigoFugir fugir;
	public TriggerSpawn fugirCinza;
	//public bool isEnabled = true;
	
    void Update() {
		//if(isEnabled == true){
		player.renderer.material = faceRed;
		StartCoroutine (Troca1 ());
		//	}
				
			
		

}
	public IEnumerator Troca1 ()
	{
		if(fugir.Perder == true && fugirCinza == false){
		player.renderer.material = faceRed;
		}
			if(fugirCinza.Perder == true && fugir.Perder == false){
		player.renderer.material = facePink;
		}
	if(fugir.Perder == false && fugirCinza.Perder == false){
		//isEnabled = false;
		
//		yield return new WaitForSeconds(0.2f);
//		player.renderer.material = faceCinza;
		yield return new WaitForSeconds(0);
		player.renderer.material = faceRed;
		yield return new WaitForSeconds(0);
		player.renderer.material = faceOrange;
		yield return new WaitForSeconds(0);
		player.renderer.material = faceYellow;
		yield return new WaitForSeconds(0);
		player.renderer.material = faceGreen;
		yield return new WaitForSeconds(0);
		player.renderer.material = faceBlue;
		yield return new WaitForSeconds(0);
		player.renderer.material = facePink;
		StartCoroutine (Troca2 ());
	}}
	
	public IEnumerator Troca2 ()
	{
		
//		yield return new WaitForSeconds(0.2f);
//		player.renderer.material = faceCinza;
		yield return new WaitForSeconds(0);
		player.renderer.material = faceRed;
		yield return new WaitForSeconds(0);
		player.renderer.material = faceOrange;
		yield return new WaitForSeconds(0);
		player.renderer.material = faceYellow;
		yield return new WaitForSeconds(0);
		player.renderer.material = faceGreen;
		yield return new WaitForSeconds(0);
		player.renderer.material = faceBlue;
		yield return new WaitForSeconds(0);
		player.renderer.material = facePink;
	
		StartCoroutine (Troca1 ());
	}
}
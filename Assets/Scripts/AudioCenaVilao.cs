using UnityEngine;
using System.Collections;

public class AudioCenaVilao : MonoBehaviour {
	public AudioClip musicaN;
	public AudioClip VilaoSound;
	public int cont=0;
	public bool Desligar;

	
	// Update is called once per frame
	void Update () {
		
		Sound();
		MusicStop();

//		if(Desligar == true){
//			musica.Stop();
//			
//		}
//		

}
	public void Sound(){
		if(cont == 0 && Desligar == false){
		audio.PlayOneShot(musicaN);
			cont=-1;
		//Desligar= true;
			
		}
	}
	public void MusicStop(){
		if(Desligar ==true){
		audio.Stop();
			cont=0;
		}
	}
}
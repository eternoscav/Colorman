using UnityEngine;
using System.Collections;

public class AudioCenaVilao3 : MonoBehaviour {
	public AudioClip Abertura;

	public int cont=0;
	public bool Desligar;

	

	void Update () {
		
		Sound();
		MusicStop();
	

}
	public void Sound(){
		if(cont == 0 && Desligar == false){
		audio.PlayOneShot(Abertura);
			cont=-1;

			
		}
	}
	public void MusicStop(){
		if(Desligar ==true){
		audio.Stop();
			cont=0;
		}
	}
}
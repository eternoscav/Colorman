using UnityEngine;
using System.Collections; 

public class CountDown : MonoBehaviour {
	public GUIText gText; // drag here the GUIText from Hierarchy view
	public GUIText TimeScore;
	public float timer =10;
	
	float maxTime;
	public GameObject timeGui;
//	public Material material1;
//	public Material material2;

	public GameObject spawn;
	public Player player;
	public AudioSource audioVilao;
	public AudioSource MusicaN;
	public AudioSource VilaoSound;
	public AudioClip vilao;
	public GameObject ampulhetas;
	public ColorCorrectionCurves colorir;
	public faceColor facecolor;
	public GameObject Caixas;
	public GameObject FundosColor;
	public GameObject FundosCinza;
	public GameObject ArcoIrisColor;
	public GameObject ArcoIrisCinza;
	public GameObject PlataformaCinza;
	public GameObject PlataformaColor;
	public GameObject Colisor;
	public GameObject FireA;
	public GameObject FireI;
	public GameObject JumpA;
	public GameObject JumpI;
	
	
	void Start(){

		audio.PlayOneShot(vilao);
		MusicaN.Pause();
		troca ();
		maxTime = timer;
		FundosColor.SetActive(true);
		FundosCinza.SetActive(false);
		PlataformaColor.SetActive(true);
		}
	
	void Update(){

	  timer -= Time.deltaTime;
		timer = Mathf.Clamp(timer, 0, maxTime);
	  float t = Mathf.Abs(timer); // get the absolute timer value
	  int seconds = (int)t % 60; // calculate the seconds
	 // int minutes = (int)t / 60; // calculate the minutes
	  string minSec =  "" + seconds; // create the formatted string
		  
		gText.text = minSec; // update the GUIText
		TimeScore.text = minSec ;
		//colorir.saturation = 0.5f;
		//colorir.enabled = true;
		//colorir.saturation =   timer * Time.deltaTime  ; 
		//colorir.saturation = Mathf.Clamp(colorir.saturation, 0, 0.5f);
	//	float finalPitch = timer / maxTime;
		
		
		if (timer <= 10){

			//timeGui.guiText.material = material2;
			timeGui.guiText.fontSize = 55;
			timeGui.guiText.pixelOffset = new Vector2(210, -4);
		//cor.GuiText.material;
				 
		}
		if (timer <= 0){
			player.transform.position = spawn.transform.position;
			Colisor.SetActive (true);
			VilaoSound.Stop();
			timer = maxTime;
			timeGui.SetActive(false);

			//timeGui.guiText.material = material1;
			timeGui.guiText.fontSize = 55;
			timeGui.guiText.pixelOffset = new Vector2(210, -4);

			ArcoIrisColor.SetActive(false);
			//colorir.saturation = 0.5f;
			//colorir.enabled = false;
			facecolor.enabled = true;
			enabled = false;
			JumpA.SetActive (true);
			JumpI.SetActive (false);
			FireA.SetActive (true);
			FireI.SetActive (false);

			
		} 
	}
			public void troca(){
		facecolor.enabled = true;

				 
		}
	

}
	
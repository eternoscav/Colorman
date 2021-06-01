using UnityEngine;
using System.Collections;

public class materialCaixa : MonoBehaviour {
	public CountDown countDown;
	public materialCaixa3 material3;
	//public TesteRandomManual troca;
	public GameObject timeGui;
	public Material material1;
    //public Material MaterialStart ;
    public Material MaterialEnd ;
	public GameObject player;
	public float duration = 1.0F;
	public GameObject Magia;
	//public int bonus;
	public bool isEnabled = false;
    void Start() {
		Testar();
	}
		void Update(){
		
		
	}	
	
	void Testar(){
		if(countDown == true && isEnabled ==false){
		isEnabled = true;
		//bonus = 20;
		player.renderer.material = MaterialEnd;
		Magia.SetActive (true);
	//	troca.cont++;
		//countDown.timer += bonus;
		timeGui.guiText.material = material1;
		timeGui.guiText.fontSize = 55;
		material3.enabled = true;
		
//		}else if (countDown == false){
//			player.renderer.material = MaterialStart;
//		}
	}
			
	}
}
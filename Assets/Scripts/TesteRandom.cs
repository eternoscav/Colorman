using UnityEngine;
using System.Collections;

public class TesteRandom : MonoBehaviour {
	public GameObject [] Placas  ;
	//public Example objeto;
    private int randNumber;
	
	// Use this for initialization
	void Start () {
	    for (int i = 0; i < Placas.Length; i++)
    Placas[i].SetActive(false);

	
	}
//	void Ramdom(){
//	      	InvokeRepeating("SwitchButtons", 0, 0);		
//	}
	    void Update(){
		if(Input.GetKeyDown(KeyCode.A))
      	InvokeRepeating("SwitchButtons", 0, 0);		
		}
    void SwitchButtons() {
    for (int i = 0; i < Placas.Length; i++)
			//if(objeto){
			if(randNumber == 0){
		Placas[i].SetActive(false);	
			
		}
    
     
    randNumber = Random.Range(0,Placas.Length);
    Placas[randNumber].SetActive(true);
    }
}

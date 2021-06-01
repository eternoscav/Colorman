using UnityEngine;
using System.Collections;

public class trocaScript : MonoBehaviour {
	//public PauseMenuScript ss;
    
    
void Update (){
		StartCoroutine (troca ()); 
	}
	public IEnumerator troca ()
	{
		
		yield return new WaitForSeconds(3);
	//	pause.enabled = true;
		
	}
	
    
}
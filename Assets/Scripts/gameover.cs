using UnityEngine;
using System.Collections;

public class gameover : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown(KeyCode.Space)){
			animation.Stop();
			animation.Blend("cont");
			 StartCoroutine(Reset());
			
			
		}else{
			animation.wrapMode = WrapMode.Loop;
			//animation["idle"].time = 0.0F;
				animation.Blend("idle");
			
	}
}
	
	public IEnumerator Reset(){
		
		yield return new WaitForSeconds(2);
		Application.LoadLevel("FASE01");
//		gameObject.SetActive(true);
		
		
	}
}
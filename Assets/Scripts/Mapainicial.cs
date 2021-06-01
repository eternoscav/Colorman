using UnityEngine;
using System.Collections;

public class Mapainicial: MonoBehaviour {
//public HeroiMapa script;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		animation.Play("idle");
		StartCoroutine (Super());
	}
	
	public IEnumerator Super ()
	{

	yield return new WaitForSeconds(5);
		Application.LoadLevel ("MAPACINZA");
	
	}
		

}
	
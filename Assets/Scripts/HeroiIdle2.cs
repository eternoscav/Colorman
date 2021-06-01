using UnityEngine;
using System.Collections;

public class HeroiIdle2: MonoBehaviour {
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

	yield return new WaitForSeconds(2);
			GameController gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
			gc.ChangeLevel("CREDITOS");
	
	}
		

}
	
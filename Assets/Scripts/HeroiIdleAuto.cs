using UnityEngine;
using System.Collections;

public class HeroiIdleAuto: MonoBehaviour {
//	public Player player;
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
		//player.enabled = true;
		//Application.LoadLevel ("FASE01");
	
	}
		

}
	
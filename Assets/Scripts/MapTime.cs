using UnityEngine;
using System.Collections;

public class MapTime: MonoBehaviour {
public HeroiMapa script;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//StartCoroutine (Super());
		//animation.Play("walk");
		animation.Stop ("walk");
		animation.Play("idle");
	}
	
	public IEnumerator Super ()
	{

	yield return new WaitForSeconds(7);
		//Application.LoadLevel ("CREDITOS");
	
	}
		

}
	
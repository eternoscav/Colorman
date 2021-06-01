using UnityEngine;
using System.Collections;

public class MovimentInimigo : MonoBehaviour {
	public Transform target;
	public float velocity;
	

	// Use this for initialization
	void Start () {
		iTween.MoveTo(gameObject, iTween.Hash("position", target.position, 
											  "speed", velocity,
											  "looptype", iTween.LoopType.pingPong,
											  "easetype", iTween.EaseType.easeOutQuad));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

using UnityEngine;
using System.Collections;

public class Star : MonoBehaviour {
	
	private float lifeTime = 3;
	public Player player;
	
	// Use this for initialization
	void Start () {
		GameObject go =  GameObject.FindWithTag("Player");
		player = go.GetComponent<Player>();
	
		Destroy(gameObject, lifeTime);
		
	}
	// Update is called once per frame
	void Update () {
		
		
		
	}
	
}

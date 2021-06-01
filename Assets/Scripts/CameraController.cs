using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
	public GameObject player;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 targetPos = new Vector3 (player.transform.position.x,
										 player.transform.position.y,
											    transform.position.z);
		if(targetPos.y >=0)
		transform.position = Vector3.Lerp (transform.position, targetPos, Time.deltaTime *1.5f);
//		iTween.MoveTo(gameObject, targetPos, 1);

		
	}
}

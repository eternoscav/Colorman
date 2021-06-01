using UnityEngine;
using System.Collections;

public class CristaisMoviment : MonoBehaviour {
	public static CristaisMoviment instance;
	public float velocidade;
	public GameObject inimigo;
	public int moveSpeed;
	public int rotationSpeed;
	public Transform target;
	public Transform[] targets;
	public int atualTarget = 0;	
	
	void Awake(){
		instance = this;
	}
	
	void Start () {

	}

	void Update ()
	{

		Debug.DrawLine (target.position, transform.position, Color.red);
		float dist = Vector3.Distance (target.position, transform.position);
	
		// get the target direction:
		Vector3 targetDir = target.position - transform.position;
		targetDir.y = 0; // kill any height difference to avoid tilting
		transform.rotation = Quaternion.Slerp (transform.rotation, Quaternion.LookRotation (targetDir), rotationSpeed * Time.deltaTime);
		if (dist > 10) { // check min distance
			// only move to the target if farther than min distance
			transform.position += transform.forward * moveSpeed * Time.deltaTime;
		}
		else{
			atualTarget ++;
			if (atualTarget >= targets.Length)
				atualTarget = 0;

			target = targets[atualTarget];
		}
		
	}
	
	
	public IEnumerator Reset(){
		
		yield return new WaitForSeconds(2);
	
	}
	
	public void AplicarDano(){
		
		//StartCoroutine(Star());
	}
	
}

	


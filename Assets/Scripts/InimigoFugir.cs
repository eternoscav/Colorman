using UnityEngine;
using System.Collections;

public class InimigoFugir : MonoBehaviour {
	public SumirCrystal Orange; 
	public SumirCrystal Yellow;
	public SumirCrystal Green;
	public SumirCrystal Blue;
	public SumirCrystal Pink;
	public GameObject vilao;
	public GameObject power;
	public GameObject cristais;
	public GameObject arcoRed;
	public GameObject arcoPink;
	public static InimigoFugir instance;
	public int moveSpeed;
	public int rotationSpeed;
	public Transform target;
	public Transform[] targets;
	public int atualTarget = 0;	
	//bool isEnabled = false;
	public bool Perder =  false; 
	
	void Awake(){
		instance = this;
		animation.Blend ("idle");
	}
	


	void Update ()
	{
		Esperar();
			
			
			
							
	}

	
		public void Esperar(){
		
		//animation.Stop ("idle");
		StartCoroutine(EsperarTempo());
		
		
		
	}
	
			public IEnumerator EsperarTempo ()
	{
		animation.CrossFade("power");
		power.SetActive (true);
		

		
		yield return new WaitForSeconds(5);
		arcoRed.SetActive(true);
		arcoPink.SetActive(false);
		power.SetActive (false);
		cristais.SetActive (true);
		Perder = true;
		
		yield return new WaitForSeconds(3);
			Orange.enabled = true;
			Yellow.enabled = true;
			Green.enabled = true;
			Blue.enabled = true;
			Pink.enabled = true;
			Orange.enabled = true;
		yield return new WaitForSeconds(2);
		animation.Stop("power");
		animation.CrossFade ("run");
		Debug.DrawLine (target.position, transform.position, Color.red);
		float dist = Vector3.Distance (target.position, transform.position);
	
		// get the target direction:
		Vector3 targetDir = target.position - transform.position;
		targetDir.y = 0; // kill any height difference to avoid tilting
		transform.rotation = Quaternion.Slerp (transform.rotation, Quaternion.LookRotation (targetDir), rotationSpeed * Time.deltaTime);
		if (dist > 2) { // check min distance
			// only move to the target if farther than min distance
			transform.position += transform.forward * moveSpeed * Time.deltaTime;
		}
		else{
			atualTarget ++;
			if (atualTarget >= targets.Length)
				atualTarget = 0;

			target = targets[atualTarget];
			vilao.SetActive (false);

		}	
	}
		

	

	
}
	

	

	


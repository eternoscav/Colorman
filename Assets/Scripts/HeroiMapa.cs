using UnityEngine;
using System.Collections;

public class HeroiMapa : MonoBehaviour {
	public static HeroiMapa instance;
	public GameObject spawn;
	public int Vidas;
	public float velocidade;
	public GameObject Inimigospawn;
	public GameObject Visao;
	public Bullet bullet;
	public GameObject spawnBullet;
	public GameObject star;
	public int moveSpeed;
	public int rotationSpeed;
	public Transform target;
	public Transform[] targets;
	public int atualTarget = 0;	
	bool isEnabled = false;
	public HeroiMapa script;
	public HeroiIdle2 script2;
	
	void Awake(){
		instance = this;
		//animation.Blend ("idle");
	}
	
	void Start () {
		
		
	}

	void Update ()
	{
		//Esperar2();
		
		if (isEnabled == false)
		{
			StartCoroutine(timer());
			
								
		}else if(isEnabled == true){
			Esperar2();
			//animation.Stop ("power");
			
		}
	}
		public void Esperar2(){
		isEnabled = true;
		//animation.Blend ("idle");
		
		//yield return new WaitForSeconds(0);
		
			
	}
	
		public void Esperar(){
		//animation.Stop ("idle");
		
		//yield return new WaitForSeconds(0);
		
		animation.Blend ("walk");
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
			
			StartCoroutine(Star());
		
			//animation.Play ("idle");
			animation.Play();
			//isEnabled = true;
		}			
	}
	public IEnumerator Star(){
		yield return new WaitForSeconds(5);
		animation.Stop ("walk");
		//script.enabled = false;
		script2.enabled = true;
		
		
			}
	
	public void Morte(){
		
		GetComponent<CharacterMotor>().enabled = false;
		
		// animacao de morte
	
		// efeito de particula
		// som de morte
		StartCoroutine(Reset());

	}
	
	public void AumentarVidas(int vida){ 
		Vidas += vida;
		
		
	}
	
	public IEnumerator Reset(){
		
		yield return new WaitForSeconds(2);
		transform.position = spawn.transform.position;
		GetComponent<CharacterMotor>().enabled = true;
			
	}
		public IEnumerator timer(){
		yield return new WaitForSeconds(0);
		Esperar();
	}
	

	
	public void AplicarDano(){
		StartCoroutine(Star());
	}
	
}

	


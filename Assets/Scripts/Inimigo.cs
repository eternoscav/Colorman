using UnityEngine;
using System.Collections;

public class Inimigo : MonoBehaviour {
	
	public static Inimigo instance;
	public InimigoIdle inimigoidle;
	public InimigoKame inimigokame;
	public GameObject guiA;
	public GameObject guiI;
	public GameObject spawn;
	public int Vidas = 3;
	public float velocidade;
	public GameObject inimigo;
    public Material MaterialStart ;
	public Material MaterialEnd ;
	public float duration = 0;
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
	public AudioClip SoundInimigo;
	
	void Awake(){
		instance = this;
	}
	
	void Start () {
		
		inimigo.renderer.material = MaterialStart;
	}

	void Update ()
	{
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
		}
		

	}
	
	public IEnumerator Star(){
		float lerp = Mathf.PingPong (Time.time, duration) / duration;
        inimigo.renderer.material.Lerp (MaterialStart, MaterialEnd, lerp);
		StartCoroutine(Colorir());
		Vidas -= 1;
		audio.PlayOneShot (SoundInimigo);
		if(Vidas == 0){
		Visao.SetActive (false);
		yield return new WaitForSeconds(0);	
		inimigoidle.enabled = true;
		inimigokame.enabled = false;
		}

		
		
			}
	
	public void Morte(){
		
		GetComponent<CharacterMotor>().enabled = false;
		

		StartCoroutine(Reset());

	}
	
	public void AumentarVidas(int vida){ 
		Vidas += vida;
		
		
	}
	
	public IEnumerator Colorir(){
		guiI.SetActive (false);
		guiA.SetActive (true);
		inimigo.renderer.material = MaterialEnd;
		yield return new WaitForSeconds(0.5f);
		guiA.SetActive (false);
		guiI.SetActive (true);
		inimigo.renderer.material = MaterialStart;
	}
	
	public IEnumerator Reset(){
		
		yield return new WaitForSeconds(2);
		transform.position = spawn.transform.position;
		GetComponent<CharacterMotor>().enabled = true;
			
	}
	
	public void AplicarDano(){
		
		StartCoroutine(Star());
	}
	
}

	


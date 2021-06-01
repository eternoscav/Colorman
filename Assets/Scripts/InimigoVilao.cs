using UnityEngine;
using System.Collections;

public class InimigoVilao : MonoBehaviour
{
	public faceColorAbertura face;
	public CristaisMoviment Red;
	public CristaisMoviment Orange;
	public CristaisMoviment Yellow;
	public CristaisMoviment Green;
	public CristaisMoviment Blue;
	public CristaisMoviment Pink;
	public static InimigoVilao instance;
	public GameObject spawn;
	public GameObject Cristais;
	public GameObject Inimigo;
	public GameObject EspelhoCinza;
	public GameObject EspelhoCores;
	public GameObject ArcoirisCinza;
	public GameObject ArcoirisCores;
	public GameObject PlataformaCinza;
	public GameObject PlataformaCores;
	public GameObject FundosCinza;
	public GameObject Power;
	public GameObject FundosCores;
	public GameObject LuzEspecial;
	public GameObject Luz2;
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
	
	void Awake ()
	{
		instance = this;
	}
	
	void Start ()
	{
		
	}

	void Update ()
	{
		StartCoroutine (Esperar ());
		
		if (isEnabled == true) {
			//glow.enabled = false;
			StartCoroutine (Esperar2 ());
			
								
		} else if (isEnabled == false) {
			
			StartCoroutine (Esperar3 ());

			animation.Stop ("power");
			//LuzEspecial.SetActive(true);
			//Luz2.SetActive(false);
			
		}
		
	}
	
	public IEnumerator Esperar ()
	{
		if (isEnabled == false) {
			
			animation.CrossFade ("idle");
			yield return new WaitForSeconds(10);
			isEnabled = true;
			animation.CrossFade ("power");
			Power.SetActive (true);
			
			//glow.blurIterations = 5;
			yield return new WaitForSeconds(1);
			

		}
		if (isEnabled == true) {
			yield return new WaitForSeconds(11);
			Red.enabled = true;
			Orange.enabled = true;
			Yellow.enabled = true;
			Green.enabled = true;
			Blue.enabled = true;
			Pink.enabled = true;
			Orange.enabled = true;
			yield return new WaitForSeconds(4);
			animation.Stop ("power");
			
			Power.SetActive (false);
			animation.CrossFade ("run");
			//isEnabled = false;
		}
		
		//isEnabled = true;
		
		//animation.Stop("power");
				
			
	}
	
	public IEnumerator Esperar2 ()
	{
		yield return new WaitForSeconds(4);
		
		
		Cristais.SetActive (true);
		Luz2.SetActive (false);
		LuzEspecial.SetActive (true);
	}
	
//	public IEnumerator Star(){
//		Inimigospawn.SetActive (false);
//		Visao.SetActive (false);
//		star.SetActive (true);
//		yield return new WaitForSeconds(2);
//		Destroy(gameObject, 1);
//			
//			}
	public IEnumerator Esperar4 ()
	{
		yield return new WaitForSeconds(0);
		face.isEnabled = false;
		//EspelhoCores.SetActive(true);
		PlataformaCinza.SetActive (true);
		PlataformaCores.SetActive (false);
		ArcoirisCinza.SetActive (true);
		ArcoirisCores.SetActive (false);
		FundosCinza.SetActive (true);
		FundosCores.SetActive (false);


		StartCoroutine (Esperar5 ());
		
		

	}

	public IEnumerator Esperar5 ()
	{
		yield return new WaitForSeconds(0);

		
		yield return new WaitForSeconds(4);
		
		//	Cristais.SetActive(false);
		
		//EspelhoCinza.SetActive(true);
		//EspelhoCores.SetActive(false);
		StartCoroutine (Esperar6 ());
		//yield return new WaitForSeconds(3);
		
	}

	public IEnumerator Esperar6 ()
	{
		
		yield return new WaitForSeconds(1);
		Application.LoadLevel ("MAPACINZA");
		//Inimigo.SetActive(false);
		yield return new WaitForSeconds(50);
	}

	public IEnumerator Esperar3 ()
	{
		yield return new WaitForSeconds(25);
		//Cristais.SetActive (false);
		//Luz2.SetActive (true);
		//LuzEspecial.SetActive(false);
		Debug.DrawLine (target.position, transform.position, Color.red);
		float dist = Vector3.Distance (target.position, transform.position);
	
		// get the target direction:
		Vector3 targetDir = target.position - transform.position;
		targetDir.y = 0; // kill any height difference to avoid tilting
		transform.rotation = Quaternion.Slerp (transform.rotation, Quaternion.LookRotation (targetDir), rotationSpeed * Time.deltaTime);
		if (dist > 2) { // check min distance
			// only move to the target if farther than min distance
			transform.position += transform.forward * moveSpeed * Time.deltaTime;
		} else {
			atualTarget ++;
			if (atualTarget >= targets.Length)
				atualTarget = 0;

			target = targets [atualTarget];
			StartCoroutine (Esperar4 ());
		}
		
	}

		
	
	
}

	


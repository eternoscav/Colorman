using UnityEngine;
using System.Collections;

public class BulletInimigo : MonoBehaviour {
	
	public float velocidade;
	public float dano;
	private float lifeTime = 5;
	private Inimigo inimigo;
	private Vector3 direcaoBala;

	// Use this for initialization
	void Start () {
		GameObject go =  GameObject.FindWithTag("Inimigo");
		inimigo = go.GetComponent<Inimigo>();
		direcaoBala = inimigo.spawnBullet.transform.forward;
		Destroy(gameObject, lifeTime);
		
	}

	
	// Update is called once per frame
	void Update () {
		transform.Translate(direcaoBala * velocidade * Time.deltaTime, Space.Self);
		
		
	}
	
	void OnTriggerEnter(Collider other){

		if(other.tag == "Player"){

			other.GetComponent<Player>().AplicarDano(0.5f);
			
		}

	}	
}

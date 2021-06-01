using UnityEngine;
using System.Collections;

public class BulletColor : MonoBehaviour {
	
	public float velocidade;
	public float dano;
	private float lifeTime = 5;
	private Player player;
	private Vector3 direcaoBala;

	// Use this for initialization
	void Start () {
		GameObject go =  GameObject.FindWithTag("Player");
		player = go.GetComponent<Player>();
		direcaoBala = player.spawnBullet.transform.forward;
		Destroy(gameObject, lifeTime);
		
	}

	
	// Update is called once per frame
	void Update () {
		transform.Translate(direcaoBala * velocidade * Time.deltaTime, Space.Self);
		
		
	}
	
	void OnTriggerEnter(Collider other){

		if(other.tag == "BulletColor"){
			Debug.Log ("Relou");
			other.GetComponent<Inimigo>().AplicarDano();
			
		}

	}	
}

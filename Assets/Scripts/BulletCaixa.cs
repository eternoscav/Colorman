using UnityEngine;
using System.Collections;

public class BulletCaixa : MonoBehaviour {
	
	public float velocidade;
	public float dano;
	private float lifeTime = 1;
	private Player player;
	private Vector3 direcaoBala;

	// Use this for initialization
	void Start () {
		GameObject go =  GameObject.FindWithTag("Player");
		player = go.GetComponent<Player>();
		direcaoBala = player.spawnBullet.transform.right;
		Destroy(gameObject, lifeTime);
		
	}

	
	// Update is called once per frame
	void Update () {
		transform.Translate(direcaoBala * velocidade * Time.deltaTime, Space.Self);
		
		
	}
	
	
}

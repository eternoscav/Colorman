using UnityEngine;
using System.Collections;

public class InimigoVisao : MonoBehaviour {
	private GameObject target;
//	public Animation animation;
	public AudioClip poder;
	public InimigoKame inimigokame;
	public BulletInimigo bullet;
	public GameObject spawnBullet;
	private float reloadTime = 1;
	public float timeControl = 0;
	private bool firstBullet = false;
	
	// Use this for initialization
	void OnTriggerEnter(Collider other){
		if(other.tag == "Player"){
			target = other.gameObject;
		}
		firstBullet = true;
	}

	void OnTriggerExit(Collider other){
		if(other.tag == "Player"){
			target = null;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
		if (target != null)
			
			Atirar();
		else {
			timeControl = reloadTime;
		}
	}
	
	public void Atirar(){
		//animation.CrossFade("kame");
		timeControl -= Time.deltaTime;
		if (timeControl <=0 || firstBullet){
			
			inimigokame.enabled = true;
			StartCoroutine(Voltar());
			Instantiate(bullet.gameObject, spawnBullet.transform.position, Quaternion.identity);
//			if (!audio.isPlaying())
			audio.PlayOneShot(poder);
			animation.CrossFade("kame");
			timeControl = reloadTime;
			firstBullet = false;
		}
	}
	public IEnumerator Voltar(){
	yield return new WaitForSeconds(0.1f);
	inimigokame.enabled = false;	
	}
}

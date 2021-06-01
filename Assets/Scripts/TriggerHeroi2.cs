using UnityEngine;
using System.Collections;

public class TriggerHeroi2 : MonoBehaviour
{
	
	public AudioSource MusicaN;
	public AudioCenaVilao2 audio2;
	public AudioCenaVilao audio1;
	public TriggerSpawn perder;
	public Player player;
	public Heroi heroi;
	public HeroiIdleAuto auto;
	public faceColor colorir;
	public GameObject DesabilitarStar;
	public GameObject Controls;
	public CountDown time;
	public GameObject paineis;
	public GameObject colisor2;
	public GameObject timegui;
	public GameObject EstrelaColor;
	public GameObject EstrelaRed;
	public GameObject EstrelaOrange;
	public GameObject EstrelaYellow;
	public GameObject EstrelaGreen;
	public GameObject EstrelaBlue;
	public GameObject EstrelaPink;
	public GameObject FireA;
	public GameObject FireI;
	public GameObject JumpA;
	public GameObject JumpI;
	

	void Start ()
	{
	

	}

	void Update ()
	{
		
	}

	void OnTriggerStay (Collider other)
	{
		if (other.tag == "Player") {
			MusicaN.Stop ();
			audio2.enabled = true;
			audio1.enabled = false;
			audio1.Desligar = true;
			animation.Play ("idle");
			heroi.enabled = false;
			auto.enabled = true;
			StartCoroutine (Super ());
		
		}
	}

	public IEnumerator Super ()
	{

		yield return new WaitForSeconds(5);
		audio2.Desligar = false;
		timegui.SetActive (true);
		EstrelaColor.SetActive (false);
		EstrelaRed.SetActive (false);
		EstrelaOrange.SetActive (false);
		EstrelaYellow.SetActive (false);
		EstrelaGreen.SetActive (false);
		EstrelaBlue.SetActive (false);
		EstrelaPink.SetActive (false);
		DesabilitarStar.SetActive (false);
		colorir.enabled = true;
		Controls.SetActive (true);
		time.enabled = true; 
		player.enabled = true;
		auto.enabled = false;
		paineis.SetActive (true);
		colisor2.SetActive (false);
		perder.Perder = false;
		JumpA.SetActive (true);
		JumpI.SetActive (false);
		FireA.SetActive (true);
		FireI.SetActive (false);

	}

}


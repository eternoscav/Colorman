using UnityEngine;
using System.Collections;

public class TriggerSpawn : MonoBehaviour {

	public TesteRandomManual ramdom;
	public AudioCenaVilao2 audio2;
	public AudioCenaVilao  audio1;
	public CountDown time;
	public bool Perder = false;
	public GameObject colisor1;
	public GameObject colisorAudio;
	public GameObject colisor2;
	public GameObject plataforma;
	public GameObject timegui;
	public GameObject HabiliteStar;
	public GameObject Redporta;
	public GameObject Orangeporta;
	public GameObject Yellowporta;
	public GameObject Greenporta;
	public GameObject Blueporta;
	public GameObject Pinkporta;
	public GameObject correntRed;
	public GameObject correntOrange;
	public GameObject correntYellow;
	public GameObject correntGreen;
	public GameObject correntBlue;
	public GameObject correntPink;
	
	public GameObject StarsRed1;
	public GameObject StarsRed2;
	public GameObject StarsRed3;

	public GameObject StarsOrange1;
	public GameObject StarsOrange2;
	public GameObject StarsOrange3;

	public GameObject StarsYellow1;
	public GameObject StarsYellow2;
	public GameObject StarsYellow3;

	public GameObject StarsGreen1;
	public GameObject StarsGreen2;
	public GameObject StarsGreen3;

	public GameObject StarsBlue1;
	public GameObject StarsBlue2;
	public GameObject StarsBlue3;

	public GameObject StarsPink1;
	public GameObject StarsPink2;
	public GameObject StarsPink3;

	
	public materialCaixa2 placared1;
	public materialCaixa2 placared2;
	public materialCaixa2 placared3;

	public materialCaixa2 placaOrange1;
	public materialCaixa2 placaOrange2;
	public materialCaixa2 placaOrange3;

	public materialCaixa2 placaYellow1;
	public materialCaixa2 placaYellow2;
	public materialCaixa2 placaYellow3;

	public materialCaixa2 placaGreen1;
	public materialCaixa2 placaGreen2;
	public materialCaixa2 placaGreen3;

	public materialCaixa2 placaBlue1;
	public materialCaixa2 placaBlue2;
	public materialCaixa2 placaBlue3;

	public materialCaixa2 placaPink1;
	public materialCaixa2 placaPink2;
	public materialCaixa2 placaPink3;

	public materialCaixa3 placaRed11;
	public materialCaixa3 placaRed22;
	public materialCaixa3 placaRed33;

	public materialCaixa3 placaOrange11;
	public materialCaixa3 placaOrange22;
	public materialCaixa3 placaOrange33;

	public materialCaixa3 placaYellow11;
	public materialCaixa3 placaYellow22;
	public materialCaixa3 placaYellow33;

	public materialCaixa3 placaGreen11;
	public materialCaixa3 placaGreen22;
	public materialCaixa3 placaGreen33;

	public materialCaixa3 placaBlue11;
	public materialCaixa3 placaBlue22;
	public materialCaixa3 placaBlue33;

	public materialCaixa3 placaPink11;
	public materialCaixa3 placaPink22;
	public materialCaixa3 placaPink33;

	
	public materialCaixa2 material2red1;
	public materialCaixa3 material3red1;
	public materialCaixa2 material2red2;
	public materialCaixa3 material3red2;
	public materialCaixa2 material2red3;
	public materialCaixa3 material3red3;

	public materialCaixa2 material2Orange1;
	public materialCaixa3 material3Orange1;
	public materialCaixa2 material2Orange2;
	public materialCaixa3 material3Orange2;
	public materialCaixa2 material2Orange3;
	public materialCaixa3 material3Orange3;

	public materialCaixa2 material2Yellow1;
	public materialCaixa3 material3Yellow1;
	public materialCaixa2 material2Yellow2;
	public materialCaixa3 material3Yellow2;
	public materialCaixa2 material2Yellow3;
	public materialCaixa3 material3Yellow3;

	public materialCaixa2 material2Green1;
	public materialCaixa3 material3Green1;
	public materialCaixa2 material2Green2;
	public materialCaixa3 material3Green2;
	public materialCaixa2 material2Green3;
	public materialCaixa3 material3Green3;

	public materialCaixa2 material2Blue1;
	public materialCaixa3 material3Blue1;
	public materialCaixa2 material2Blue2;
	public materialCaixa3 material3Blue2;
	public materialCaixa2 material2Blue3;
	public materialCaixa3 material3Blue3;

	public materialCaixa2 material2Pink1;
	public materialCaixa3 material3Pink1;
	public materialCaixa2 material2Pink2;
	public materialCaixa3 material3Pink2;
	public materialCaixa2 material2Pink3;
	public materialCaixa3 material3Pink3;

	
	public materialPainelChefaoRed red1;
	public materialPainelChefaoRed red2;
	public materialPainelChefaoRed red3;

	public materialPainelChefaoOrange Orange1;
	public materialPainelChefaoOrange Orange2;
	public materialPainelChefaoOrange Orange3;

	public materialPainelChefaoYellow Yellow1;
	public materialPainelChefaoYellow Yellow2;
	public materialPainelChefaoYellow Yellow3;

	public materialPainelChefaoGreen Green1;
	public materialPainelChefaoGreen Green2;
	public materialPainelChefaoGreen Green3;

	public materialPainelChefaoBlue Blue1;
	public materialPainelChefaoBlue Blue2;
	public materialPainelChefaoBlue Blue3;

	public materialPainelChefaoPink Pink1;
	public materialPainelChefaoPink Pink2;
	public materialPainelChefaoPink Pink3;

	
	public GameObject placa01  ;
	public GameObject placa02  ;
	public GameObject placa03  ;
	public GameObject placa04  ;
	public GameObject placa05  ;
	public GameObject placa06  ;
	public GameObject placa07  ;
	public GameObject placa08  ;
	public GameObject placa09  ;
	public GameObject placa10  ;
	public GameObject placa11  ;
	public GameObject placa12  ;
	public GameObject placa13  ;
	public GameObject placa14  ;
	public GameObject placa15  ;
	public GameObject placa16  ;
	public GameObject placa17  ;
	public GameObject placa18  ;
	public GameObject placa19  ;

	void Start () {
		
		
		
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter(Collider other){
		//Debug.Log ("Teste");
		if(other.tag == "Player"){
			//Perder = true;
			//ramdom.cont = 0;
			audio2.Desligar = true;
			audio1.enabled = true;
			audio2.enabled = false;
			Player p = other.gameObject.GetComponent<Player>();
			StarsRed1.SetActive(false);
			foreach (Transform r1 in StarsRed1.transform)
			r1.gameObject.SetActive(false);
			
			StarsRed2.SetActive(false);
			foreach (Transform r2 in StarsRed2.transform)
			r2.gameObject.SetActive(false);
			
			StarsRed3.SetActive(false);
			foreach (Transform r3 in StarsRed3.transform)
			r3.gameObject.SetActive(false);
			

			
			StarsOrange1.SetActive(false);
			foreach (Transform o1 in StarsOrange1.transform)
			o1.gameObject.SetActive(false);
			
			StarsOrange2.SetActive(false);
			foreach (Transform o2 in StarsOrange2.transform)
			o2.gameObject.SetActive(false);
			
			StarsOrange3.SetActive(false);
			foreach (Transform o3 in StarsOrange3.transform)
			o3.gameObject.SetActive(false);
			

			StarsYellow1.SetActive(false);
			foreach (Transform y1 in StarsYellow1.transform)
			y1.gameObject.SetActive(false);
			
			StarsYellow2.SetActive(false);
			foreach (Transform y2 in StarsYellow2.transform)
			y2.gameObject.SetActive(false);
			
			StarsYellow3.SetActive(false);
			foreach (Transform y3 in StarsYellow3.transform)
			y3.gameObject.SetActive(false);
			

			StarsGreen1.SetActive(false);
			foreach (Transform g1 in StarsGreen1.transform)
			g1.gameObject.SetActive(false);
			
			StarsGreen2.SetActive(false);
			foreach (Transform g2 in StarsGreen2.transform)
			g2.gameObject.SetActive(false);
			
			StarsGreen3.SetActive(false);
			foreach (Transform g3 in StarsGreen3.transform)
			g3.gameObject.SetActive(false);
			

			StarsBlue1.SetActive(false);
			foreach (Transform b1 in StarsBlue1.transform)
			b1.gameObject.SetActive(false);
			
			StarsBlue2.SetActive(false);
			foreach (Transform b2 in StarsBlue2.transform)
			b2.gameObject.SetActive(false);
			
			StarsBlue3.SetActive(false);
			foreach (Transform b3 in StarsBlue3.transform)
			b3.gameObject.SetActive(false);
			

			
			StarsPink1.SetActive(false);
			foreach (Transform p1 in StarsPink1.transform)
			p1.gameObject.SetActive(false);
						
			StarsPink2.SetActive(false);
			foreach (Transform p2 in StarsPink2.transform)
			p2.gameObject.SetActive(false);
			
			StarsPink3.SetActive(false);
			foreach (Transform p3 in StarsPink3.transform)
			p3.gameObject.SetActive(false);
			

			HabiliteStar.SetActive (true);
			p.AumentarVidas(-1);
			ramdom.enabled = false;
			StartCoroutine (Super ());
			
		placa01.SetActive (true);
		placa02.SetActive (false);
		placa03.SetActive (false);
		placa04.SetActive (false);
		placa05.SetActive (false);
		placa06.SetActive (false);
		placa07.SetActive (false);
		placa08.SetActive (false);
		placa09.SetActive (false);
		placa10.SetActive (false);
		placa11.SetActive (false);
		placa12.SetActive (false);
		placa13.SetActive (false);
		placa14.SetActive (false);
		placa15.SetActive (false);
		placa16.SetActive (false);
		placa17.SetActive (false);
		placa18.SetActive (false);
		placa19.SetActive (false);

			
		}

}
		public IEnumerator Super ()
	{
		plataforma.SetActive (false);
		yield return new WaitForSeconds(1);
		audio1.Desligar = false;
		red1.collider.isTrigger = true;
		red2.collider.isTrigger = true;
		red3.collider.isTrigger = true;

		Orange1.collider.isTrigger = true;
		Orange2.collider.isTrigger = true;
		Orange3.collider.isTrigger = true;

		Yellow1.collider.isTrigger = true;
		Yellow2.collider.isTrigger = true;
		Yellow3.collider.isTrigger = true;

		Green1.collider.isTrigger = true;
		Green2.collider.isTrigger = true;
		Green3.collider.isTrigger = true;

		Blue1.collider.isTrigger = true;
		Blue2.collider.isTrigger = true;
		Blue3.collider.isTrigger = true;

		Pink1.collider.isTrigger = true;
		Pink2.collider.isTrigger = true;
		Pink3.collider.isTrigger = true;

		ramdom.cont = 0;
		timegui.SetActive (false);
		ramdom.enabled = true;

		Perder = true;
		colisorAudio.SetActive (true);
		colisor1.SetActive (true);
		colisor2.SetActive (true);
		material2red1.enabled = true;
		material3red1.enabled = false;
		material2red2.enabled = true;
		material3red2.enabled = false;
		material3red3.enabled = false;
		material2red3.enabled = true;

		
		material2Orange1.enabled = true;
		material3Orange1.enabled = false;
		material2Orange2.enabled = true;
		material3Orange2.enabled = false;
		material3Orange3.enabled = false;
		material2Orange3.enabled = true;

		
		material2Yellow1.enabled = true;
		material3Yellow1.enabled = false;
		material2Yellow2.enabled = true;
		material3Yellow2.enabled = false;
		material3Yellow3.enabled = false;
		material2Yellow3.enabled = true;

		
		material2Green1.enabled = true;
		material3Green1.enabled = false;
		material2Green2.enabled = true;
		material3Green2.enabled = false;
		material3Green3.enabled = false;
		material2Green3.enabled = true;

		
		material2Blue1.enabled = true;
		material3Blue1.enabled = false;
		material2Blue2.enabled = true;
		material3Blue2.enabled = false;
		material3Blue3.enabled = false;
		material2Blue3.enabled = true;

		
		material2Pink1.enabled = true;
		material3Pink1.enabled = false;
		material2Pink2.enabled = true;
		material3Pink2.enabled = false;
		material3Pink3.enabled = false;
		material2Pink3.enabled = true;

		
		placared1.enabled = true;
		placared2.enabled = true;
		placared3.enabled = true;

		
		placaOrange1.enabled = true;
		placaOrange2.enabled = true;
		placaOrange3.enabled = true;

		
		placaYellow1.enabled = true;
		placaYellow2.enabled = true;
		placaYellow3.enabled = true;

		
		placaGreen1.enabled = true;
		placaGreen2.enabled = true;
		placaGreen3.enabled = true;

		
		placaBlue1.enabled = true;
		placaBlue2.enabled = true;
		placaBlue3.enabled = true;

		
		placaPink1.enabled = true;
		placaPink2.enabled = true;
		placaPink3.enabled = true;

		
		placaRed11.enabled = false;
		placaRed22.enabled = false;
		placaRed33.enabled = false;

		
		placaOrange11.enabled = false;
		placaOrange22.enabled = false;
		placaOrange33.enabled = false;

		
		placaYellow11.enabled = false;
		placaYellow22.enabled = false;
		placaYellow33.enabled = false;

		
		placaGreen11.enabled = false;
		placaGreen22.enabled = false;
		placaGreen33.enabled = false;

		
		placaBlue11.enabled = false;
		placaBlue22.enabled = false;
		placaBlue33.enabled = false;

		
		placaPink11.enabled = false;
		placaPink22.enabled = false;
		placaPink33.enabled = false;

		
		Redporta.SetActive (true);
		Orangeporta.SetActive (true);
		Yellowporta.SetActive (true);
		Greenporta.SetActive (true);
		Blueporta.SetActive (true);
		Pinkporta.SetActive (true);
		
		correntRed.SetActive (true);
		correntOrange.SetActive (true);
		correntYellow.SetActive (true);
		correntGreen.SetActive (true);
		correntBlue.SetActive (true);
		correntPink.SetActive (true);
		
	}
	
}



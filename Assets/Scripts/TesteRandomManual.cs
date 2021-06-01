using UnityEngine;
using System.Collections;

public class TesteRandomManual : MonoBehaviour
{
	public GuardiaoIdle guadiao;
	public int Crystals;
	public CountDown time;
	public GameObject Colisor;
	public GameObject PortaVermelha;
	public GameObject PortaLaranja;
	public GameObject PortaAmarela;
	public GameObject PortaVerde;
	public GameObject PortaAzul;
	public GameObject PortaRosa;
	public GameObject Vermelho  ;
	public GameObject Laranja  ;
	public GameObject Amarelo  ;
	public GameObject Verde  ;
	public GameObject Azul  ;
	public GameObject Rosa  ;
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
	public int cont;

	void Start ()
	{
		
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
		
	
	}
	
	void Update ()
	{
		if (time.enabled == false) {
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

		}
//		if (cont == 1) {
//			placa01.SetActive (true);
//		}
		if (cont == 1) {
			placa02.SetActive (true);
		}
		if (cont == 2) {
			placa03.SetActive (true);
		}
		if (cont == 3) {
			placa04.SetActive (true);
			Vermelho.SetActive (false);
			PortaVermelha.SetActive (false);
		}
		if (cont == 4) {
			placa05.SetActive (true);
		}
		if (cont == 5) {
			placa06.SetActive (true);

		}
		if (cont == 6) {
			placa07.SetActive (true);
			Laranja.SetActive (false);
			PortaLaranja.SetActive (false);
		}
		if (cont == 7) {
			placa08.SetActive (true);
		}
		if (cont == 8) {
			placa09.SetActive (true);
		}
		if (cont == 9) {
			placa10.SetActive (true);
			Amarelo.SetActive (false);
			PortaAmarela.SetActive (false);
		}
		if (cont == 10) {
			placa11.SetActive (true);

		}
		if (cont == 11) {
			placa12.SetActive (true);

		}
		if (cont == 12) {
			placa13.SetActive (true);
			Verde.SetActive (false);
			PortaVerde.SetActive (false);
		}
		if (cont == 13) {
			placa14.SetActive (true);
		}
		if (cont == 14) {
			placa15.SetActive (true);
		}
		if (cont == 15) {
			placa16.SetActive (true);
			Azul.SetActive (false);
			PortaAzul.SetActive (false);

		}
		if (cont == 16) {
			placa17.SetActive (true);

		}
		if (cont == 17) {
			placa18.SetActive (true);
		}
		if (cont == 18) {
			placa19.SetActive (true);
			Rosa.SetActive (false);
			Colisor.SetActive (true);
			PortaRosa.SetActive (false);
			guadiao.enabled = true;
		}
		
	}

	public void Trocar ()
	{

		if (cont == 1)
			placa01.SetActive (true);
		if (cont == 2)
			placa02.SetActive (true);
		if (cont == 3)
			placa03.SetActive (true);
		if (cont == 4)
			placa04.SetActive (true);
		if (cont == 5)
			placa05.SetActive (true);
		if (cont == 6)
			placa06.SetActive (true);
		if (cont == 7)
			placa07.SetActive (true);
		if (cont == 8)
			placa08.SetActive (true);
		if (cont == 9)
			placa09.SetActive (true);
		if (cont == 10)
			placa10.SetActive (true);
		if (cont == 11)
			placa11.SetActive (true);
		if (cont == 12)
			placa12.SetActive (true);
		if (cont == 13)
			placa13.SetActive (true);
		if (cont == 14)
			placa14.SetActive (true);
		if (cont == 15)
			placa15.SetActive (true);
		if (cont == 16)
			placa16.SetActive (true);
		if (cont == 17)
			placa17.SetActive (true);
		if (cont == 18)
			placa18.SetActive (true);
	}

	public void RecolherCrystal (int crystal)
	{
		Crystals += crystal;
		cont += 1;

		
	}
}

			

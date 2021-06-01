using UnityEngine;
using System.Collections;

public class TriggerTroca : MonoBehaviour {
    public TrocaCor Plat10;
	public TrocaCor Plat09;
	public TrocaCor Plat08;
	public TrocaCor Plat07;
	public TrocaCor Plat06;
	public TrocaCor Plat05;
	public materialPlataforma plata05;
	public materialPlataforma plata06;
	public materialPlataforma plata07;
	public materialPlataforma plata08;
	public materialPlataforma plata09;
	public materialPlataforma plata10;
	public PlataformMoviment mov05;
	public PlataformMoviment mov06;
	public PlataformMoviment mov07;
	//public PlataformMoviment mov08;
	public PlataformMoviment mov09;
	public PlataformMoviment mov10;
	

	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}
	
	void OnTriggerEnter(Collider other){

		if(other.tag == "bullet" ||  other.tag == "BulletYellow" || other.tag == "BulletRed"  ||  other.tag == "BulletGreen" || 
			other.tag == "BulletBlue" ||  other.tag == "BulletPink" ||  other.tag == "BulletOrange"){
			Plat05.enabled = true;
			Plat06.enabled = true;
			Plat07.enabled = true;
			Plat08.enabled = true;
			Plat09.enabled = true;
			Plat10.enabled = true;
			plata05.enabled = true;
			plata06.enabled = true;
			plata07.enabled = true;
			plata08.enabled = true;
			plata09.enabled = true;
			plata10.enabled = true;
			mov05.enabled = true;
			mov06.enabled = true;
			mov07.enabled = true;
			//mov08.enabled = true;
			mov09.enabled = true;
			mov10.enabled = true;
		}

	}
}

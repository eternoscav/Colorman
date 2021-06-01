using UnityEngine;
using System.Collections;

public class CaixaMovel : MonoBehaviour {
	//public CountDown countDown;
	//public TesteRandomManual troca;
	//public GameObject timeGui;
	public Material material1;
    public Material MaterialStart ;
    public Material MaterialEnd ;
	public GameObject colisor;
	public GameObject colisor2;
	public GameObject player;
	public float duration = 1.0F;
	public GameObject Magia;
	//public int bonus;
    void Start() {
		//bonus = 20;
		player.renderer.material = MaterialStart;
		float lerp = Mathf.PingPong (Time.time, duration) / duration;
        player.renderer.material.Lerp (MaterialStart, MaterialEnd, lerp);
		player.renderer.material = MaterialEnd;
		Magia.SetActive (true);
		colisor.SetActive (true);
		
		//TesteRandomManual p = gameObject.GetComponent<TesteRandomManual>();
		//p.RecolherCrystal(1);
		//troca.cont++;
		//countDown.timer += bonus;
		//timeGui.guiText.material = material1;
	//	timeGui.guiText.fontSize = 80;
		//rigidbody.constraints = RigidbodyConstraints.FreezeRotation;
		rigidbody.constraints &= ~RigidbodyConstraints.FreezePositionX;

//		StartCoroutine (unfreeze4 ());
//		StartCoroutine (unfreeze ());
//		StartCoroutine (unfreeze2 ());
//		StartCoroutine (unfreeze3 ());
//		
//		
//		
//	
//    }
//	public IEnumerator  unfreeze4(){
//		yield return new WaitForSeconds(0);
//		rigidbody.constraints = RigidbodyConstraints.None;
//	}
//
//	public IEnumerator  unfreeze(){
//		yield return new WaitForSeconds(0);
//		rigidbody.constraints = RigidbodyConstraints.FreezeRotation;
//	}
//		public IEnumerator  unfreeze2(){
//		yield return new WaitForSeconds(2);
//		rigidbody.constraints = RigidbodyConstraints.FreezePositionZ;
//	}
//			public IEnumerator  unfreeze3(){
//		yield return new WaitForSeconds(1);
//		rigidbody.constraints = RigidbodyConstraints.FreezePositionY;
	}
	
				void OnTriggerEnter(Collider other){
		
				if(other.tag == "Caixa"){
			rigidbody.constraints = RigidbodyConstraints.FreezePosition |RigidbodyConstraints.FreezeRotation;
			colisor.collider.enabled = false;
			colisor2.SetActive(false);

		}
						if(other.tag == "Caixa2"){
			rigidbody.constraints = RigidbodyConstraints.FreezePosition |RigidbodyConstraints.FreezeRotation;
			colisor.collider.enabled = false;
			colisor2.SetActive (true);
			

		}

		}		
			

	
		
}
using UnityEngine;
using System.Collections;

public class Aula1 : MonoBehaviour
{
	public GameObject cubo;
	public float speed;
	public Color novaCor;
	public Color startColor;
	public Color[] listaCores;
	
	void Start(){
		ImprimirDebug();
	}
	
	public void ImprimirDebug()
	{
		Debug.Log("Debug");
	}
	
	// Update is called once per frame
	void Update ()
	{

		// move o cubo pra esquerda
		if (Input.GetKey(KeyCode.D)){
			cubo.transform.Translate(new Vector3(speed * Time.deltaTime, 0 ,0 ));
//			cubo.transform.position = new Vector3(cubo.transform.position.x + 1 * Time.deltaTime,cubo.transform.position.y, cubo.transform.position.z);
		}
		// move o cubo pra direita
		if (Input.GetKey(KeyCode.A)){
			cubo.transform.position = new Vector3(cubo.transform.position.x - speed * Time.deltaTime,cubo.transform.position.y, cubo.transform.position.z);
		}
		
		// Muda cor do cudo 
		if (Input.GetKey(KeyCode.C)){
			cubo.renderer.material.color = Color.Lerp(cubo.renderer.material.color, listaCores[1], Time.deltaTime);
		}
		else{
			// volta para a cor original do cubo
			cubo.renderer.material.color = Color.Lerp(cubo.renderer.material.color, startColor, Time.deltaTime); 
		}
		
		if (Input.GetButton("Jump")){
			Debug.Log("Jump");
		}
		
	}
}

using UnityEngine;
using System.Collections;

public class rotacaoPainel : MonoBehaviour {
	public int rotation = 0;
	public int incremento = 1;
	// Use this for initialization

	// Update is called once per frame
	void Update () {
	rotation += incremento;
		//if(rotation >= 360 || rotation <= 0){
//			incremento = -incremento;
			transform.Rotate(0,0 ,rotation * Time.deltaTime );

			
		//}
	}
}

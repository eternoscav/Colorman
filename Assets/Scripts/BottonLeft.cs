using UnityEngine;
using System.Collections;

public class BottonLeft : MonoBehaviour {
	public Player player;
	public Texture2D NormalTex;
	//public Texture2D HoverTex;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//transform.position = new Vector3 (transform.position.x, transform.position.y, 0);
		//if (Input.GetButtonDown ("Jump"))
		guiTexture.texture = NormalTex;

}
		void OnMouseEnter() {
		//Input.GetButtonDown ("run");
				player.animation.Blend ("run");
			//Player p = GetComponent<Player>();
			//p.PressBoton(1);
		//guiTexture.texture = NormalTex;
	}
	
		//	void OnMouseExit() {
	 //Debug.Log("SAIU");
		//guiTexture.texture = HoverTex;
	}
//	
//			void OnMouseDown() {
//	 Debug.Log("clicked");
//	}
//}

    
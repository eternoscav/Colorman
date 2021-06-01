using UnityEngine;
using System.Collections;

public class BottonUp: MonoBehaviour
{
	public CharacterMotor motor;
	public GameObject color;
	public Player player;

	void Update ()
	{
		if (Input.touches.Length <= 0) {
			
		} else {
			for (int i = 0; i<Input.touchCount; i++)
				if (this.guiTexture.HitTest (Input.GetTouch (i).position)) {
					if (Input.GetTouch (i).phase == TouchPhase.Began) {
						motor.inputJump = true;
						player.animation.Blend("jump");
						color.SetActive (true);
					}
					if (Input.GetTouch (i).phase == TouchPhase.Ended) {
						color.SetActive (false);
						motor.inputJump = false;
 
					}

				}
		}
	}
}


//using UnityEngine;
//using System.Collections;
//
//public class BottonUp: MonoBehaviour {
//	public Player player;
//	public GameObject color;
//	public CharacterMotor motor; 
//	void Start () {
//	
//	}
//	
//	// Update is called once per frame
//	void Update () {
//		//transform.position = new Vector3 (transform.position.x, transform.position.y, 0);
//		//if (Input.GetButtonDown ("Jump"))
//		//guiTexture.texture = NormalTex;
//
//}
//		void OnMouseEnter() {
//		player.animation.Blend("jump");
//		color.SetActive (true);
//		motor.inputJump = true;
//		//Input.GetButtonDown ("walk");
//				//motor.inputMoveDirection = directionVector;
//			//Player p = GetComponent<Player>();
//			//p.PressBoton(1);
//		//guiTexture.texture = NormalTex;
//	}
//	
//	void OnMouseExit() {
//		//player.animation.Blend("run");
//		color.SetActive (false);
//		motor.inputJump = false;
//		//Input.GetButtonDown ("walk");
//				//motor.inputMoveDirection = directionVector;
//			//Player p = GetComponent<Player>();
//			//p.PressBoton(1);
//		//guiTexture.texture = NormalTex;
//	}
//	
//		//	void OnMouseExit() {
//	 //Debug.Log("SAIU");
//		//guiTexture.texture = HoverTex;
//	}
////	
////			void OnMouseDown() {
////	 Debug.Log("clicked");
////	}
////}
//
//    
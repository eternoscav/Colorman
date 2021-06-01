using UnityEngine;
using System.Collections;

public class BottonSpeed: MonoBehaviour
{
	
	public GameObject color;
	public Player player;

	void Update ()
	{
		if (Input.touches.Length <= 0) {
			
		} else {
			for (int i = 0; i<Input.touchCount; i++)
				if (this.guiTexture.HitTest (Input.GetTouch (i).position)) {
					if (Input.GetTouch (i).phase == TouchPhase.Began) {
						//motor.movement.maxForwardSpeed = 15;
						player.animation.Blend("run");
						color.SetActive (true);
					}
					if (Input.GetTouch (i).phase == TouchPhase.Ended) {
						color.SetActive (false);
						
 
					}

				}
		}
	}

}
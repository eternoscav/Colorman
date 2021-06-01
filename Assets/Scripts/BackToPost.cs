using UnityEngine;
using System.Collections;

public class BackToPost : MonoBehaviour 
{
	private float guiRatio;
	private float sWidth;
	private Vector3 GUIsF;

	void Awake()
	{
		sWidth = Screen.width;
		guiRatio = sWidth/1000;
		GUIsF = new Vector3(guiRatio,guiRatio,1);
	}
	
	void OnGUI()
	{
		GUI.matrix = Matrix4x4.TRS(new Vector3(Screen.width/2,Screen.height-30,0),Quaternion.identity,GUIsF);
		if(GUI.Button(new Rect(-50,-20,100,30),"Back to post..."))
		{
			Application.OpenURL("http://www.41post.com/?p=3816");
		}
	}
}

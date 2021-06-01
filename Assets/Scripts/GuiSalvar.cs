using UnityEngine;
using System.Collections;

public class GuiSalvar : MonoBehaviour {

	// Use this for initialization
	void Start () {
	DontDestroyOnLoad(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
			if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space)) {
			Destroy (gameObject);
		}
	//StartCoroutine (Super());
	
		
}
	public IEnumerator Super ()
	{
		yield return new WaitForSeconds(5);
		
	}
}
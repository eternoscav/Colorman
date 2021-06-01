function Update () {

if(Input.GetKey("escape")) {
		//pause the game
		Time.timeScale = 0;
		//show the pause menu
		var script3: MainMenuScript = GetComponent("PauseMenuScript"); 
		script3.enabled = true;
		//disable the cursor hiding script
		var script4 : MainMenuScript = GetComponent("HideCursorScript"); 
		script4.enabled = false; 
		}
}
var mainMenuSceneName : String;
var pauseMenuFont : Font;
private var pauseEnabled = false;	
var pause : MenuWindow;	
var menu : PauseMenu ;	
var colorir : ColorCorrectionCurves;
var Heroi3: GameObject;
var Controls: GameObject;
Screen.SetResolution (Screen.currentResolution.width, Screen.currentResolution.height, true);
var width : int = 924; //Reference resolution
var height : int = 868; //Reference resolution
Screen.SetResolution (924, 468, false);
Screen.fullScreen = true;

function Start(){
	pauseEnabled = false;
	Time.timeScale = 1;
	AudioListener.volume = 1;
	Screen.showCursor = false;
}

function Update(){

	//check if pause button (escape key) is pressed
	if(Input.GetKeyDown("escape")){
	
		if(pauseEnabled == true){
		colorir.saturation = 1;
		colorir.enabled = false;

		//animation.Blend("idle");
		Controls.SetActive (true);
		//Heroi3.renderer.enabled = false;
			pauseEnabled = false;
			Time.timeScale = 1;
			AudioListener.volume = 1;
			Screen.showCursor = false;			
		}

		else if(pauseEnabled == false){
			colorir.saturation = 0;
			colorir.enabled = true;
			//Heroi3.renderer.enabled = true;
			Controls.SetActive (false);
			pauseEnabled = true;
			AudioListener.volume = 0;
			Time.timeScale = 0;
			Screen.showCursor = true;
		}
	}
}

private var showGraphicsDropDown = false;
public static function AutoResize(screenWidth:int, screenHeight:int):void
{
    var resizeRatio:Vector2 = Vector2(Screen.width / parseFloat(screenWidth), Screen.height / parseFloat(screenHeight));
    GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, Vector3(resizeRatio.x, resizeRatio.y, 1.0));
    }

function OnGUI(){
var oldMatrix : Matrix4x4;
var tMatrix : Matrix4x4;
oldMatrix = GUI.matrix; //Store current matrix
tMatrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, Vector3(1.0*Screen.width/width, 1.0*Screen.height/height, 1.0)); //Construct matrix to scale to actual view size
GUI.matrix = tMatrix; //Set the GUI matrix to the scaling matrix
GUI.matrix = oldMatrix; //Set the original matrix back
GUI.skin.box.font = pauseMenuFont;
GUI.skin.button.font = pauseMenuFont;

	if(pauseEnabled == true){
		//GUI.color = Color.red;
		GUI.Box(Rect(Screen.width /2 - 100,Screen.height /2 - 80,250,180), "PAUSE");
		GUI.color = Color.white;
		//Make Main Menu button
		if(GUI.Button(Rect(Screen.width /2 - 100,Screen.height /2 - 50,250,50), "MENU INICIAR")){
			Application.LoadLevel("MENU");
		}
		
			if(GUI.Button(Rect(Screen.width /2 - 100,Screen.height /2 ,250,50), "GRAFICO QUALIDADE")){
			
			if(showGraphicsDropDown == false){
				showGraphicsDropDown = true;
			}
			else{
				showGraphicsDropDown = false;
			}
		}
		
		if(showGraphicsDropDown == true){
			if(GUI.Button(Rect(Screen.width /2 + 150,Screen.height /2 ,250,50), "FRACA")){
				QualitySettings.currentLevel = QualityLevel.Fastest;
			}
			if(GUI.Button(Rect(Screen.width /2 + 150,Screen.height /2 + 50,250,50), "NORMAL")){
				QualitySettings.currentLevel = QualityLevel.Good;
			}
			if(GUI.Button(Rect(Screen.width /2 + 150,Screen.height /2 + 100,250,50), "BOM")){
				QualitySettings.currentLevel = QualityLevel.Fantastic;
			}
			
			
			if(Input.GetKeyDown("escape")){
			
				showGraphicsDropDown = false;
			}
		}

		if (GUI.Button (Rect (Screen.width /2 - 100,Screen.height /2 + 50,250,50), "SAIR")){
		pause.enabled = true;
		pauseEnabled = false;
		}
	}




						
}
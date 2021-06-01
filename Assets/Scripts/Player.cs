using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
	
	public CountDown countDown;
	public bool p = false;
	public bool v = false;
	public bool or = false;
	public bool ye = false;
	public bool gr = false;
	public bool bl = false;
	public bool pi = false;
	public GameObject MagiaRedGui;
	public GameObject MagiaOrangeGui;
	public GameObject MagiaYellowGui;
	public GameObject MagiaGreenGui;
	public GameObject MagiaBlueGui;
	public GameObject MagiaPinkGui;
	public ColorCorrectionCurves color;
	public facetroca facetroca;
	public facetroca2 facetroca2;
	public static Player instance;
	public GameObject Controls;
	public GameObject timeGui;
	public Material material1;
	public GameObject spawn;
	public GameObject spawnRed;
	public GameObject spawnOrange;
	public GameObject spawnYellow;
	public GameObject spawnGreen;
	public GameObject spawnBlue;
	public GameObject spawnPink;
	public GameObject spawntime;
	public GameObject time;
	public GameObject ArcoIrisColor;
	public GameObject ArcoIrisCinza;
	public GameObject FundosColor;
	public GameObject FundosCinza;
	public GameObject PlataformaColor;
	public GameObject PlataformaCinza;
	public TriggerCrystal colisor;
	public Texture2D coracao;
	public Texture2D meioCoracao;
	public GUIText estrelasGUI;
	public GUIText estrelasGUIScore;
	public GUIText estrelasGUI2;
	public GameObject estrelasGUI22;
	public GameObject estrelasGUI11;
	public GUIText refGUI;
	public GUIText refGUIScore;
	public GUIText moedaoGUI;
	public GUIText VidaGui;
	public GUIText VidaScore;
	public GUITexture[] coracoes;
	public int Crystals;
	public int NumInimigo;
	public int ColVilao;
	public int estrelas;
	public int Fases;
	public int Spawns = 0;
	public int Vidas;
	public int Coracoes;
	public int Caixas;
	int coracaoAtual = 0;
	bool isDead = false;
	private float largura;
	public AudioClip SoundStar;
	public AudioClip Dead;
	public AudioClip Dano;
	public AudioClip vilao;
	public AudioClip VilaoSound;
	public AudioClip poder;
	public AudioClip fas;
	public AudioClip SoundCoracao;
	public AudioClip crystalSound;
	public AudioClip SoundKey;
	public GameObject PortalAtivo;
	public GameObject PortalInativo;
	public GameObject Heroi;
	public Bullet bullet;
	public BulletRed bulletred;
	public BulletGreen bulletgreen;
	public BulletBlue bulletblue;
	public BulletPink bulletpink;
	public BulletOrange bulletorange;
	public BulletYellow bulletyellow;
	public Star star;
	public GameObject spawnBullet;
	public GameObject spawnStar;
	private PlatformInputController platformInput;
	//private CharacterController m_charController;
	private CharacterMotor m_charMotor; 
	public string idle;
	public string walk;
	public string run;
	public string jump;
	public string fire;
	public string power;
	public string empurrar;
	public string cont;
	
	
	public enum Estado
	{
		walk,
		idle, 
		run, 
		fire,
		power,
		empurrar,
		cont,
		jump,

	}
	
	public Estado m_estado;
	
	void SetEstado (Estado estado)
	{
		if (m_estado == estado)
			return;
		
		m_estado = estado;
		
		switch (m_estado) {
		case Estado.idle:
			animation.CrossFade (idle);
			break;
		case Estado.walk:
			animation.CrossFade (walk);
			break;
		case Estado.run :
			animation.CrossFade (run);
			break;
		case Estado.jump :
			animation.CrossFade (jump);
			break;
		case Estado.fire :
			animation.CrossFade (fire);
			break;

		}
	}

	void ConferirEstado ()
	{
		if (IsGrounded () == false) {
			SetEstado (Estado.jump);
		} else if (xAxis > 0.1 || xAxis < -0.1) {
			if (xAxis > 0.5 || xAxis < -0.5) {
				SetEstado (Estado.run);
			} else {
				SetEstado (Estado.walk);
			}
		} else if (xAxis == 0) {
			SetEstado (Estado.idle);
		}
		
	}
	
	void Awake ()
	{
		instance = this;
		
		platformInput = GetComponent<PlatformInputController> ();
		
	}
	
	void OnEnable ()
	{
		
		EasyJoystick.On_JoystickMove += On_JoystickMove;	
		EasyJoystick.On_JoystickMoveEnd += On_JoystickMoveEnd;
		EasyButton.On_ButtonPress += On_ButtonPress;
		EasyButton.On_ButtonUp += On_ButtonUp;	
	}

	void OnDisable ()
	{
		EasyJoystick.On_JoystickMove -= On_JoystickMove;	
		EasyJoystick.On_JoystickMoveEnd -= On_JoystickMoveEnd;
		EasyButton.On_ButtonPress -= On_ButtonPress;
		EasyButton.On_ButtonUp -= On_ButtonUp;	
	}
		
	void OnDestroy ()
	{
		EasyJoystick.On_JoystickMove -= On_JoystickMove;	
		EasyJoystick.On_JoystickMoveEnd -= On_JoystickMoveEnd;
		EasyButton.On_ButtonPress -= On_ButtonPress;
		EasyButton.On_ButtonUp -= On_ButtonUp;	
	}
	
	float xAxis;
//	float yAxis;
	
	void On_JoystickMove (MovingJoystick move)
	{
	
//		float angle = move.Axis2Angle (true);
		
		xAxis = move.joystickValue.x;
		//yAxis = move.joystickValue.y;
		
		platformInput.directionVector.x = xAxis;

	}
	
	void On_JoystickMoveEnd (MovingJoystick move)
	{
		xAxis = 0;
		//yAxis = 0; 

	}
	
	void On_ButtonPress (string buttonName)
	{
		if ( buttonName == "Fire" || buttonName == "FireRed" || buttonName == "FireOrange" || buttonName == "FireYellow" || buttonName == "FireGreen" || 
			buttonName == "FireBlue" || buttonName == "FirePink") {
			animation.Blend ("kame");
			//SetEstado(Estado.fire);
			if (p == true) {
				MagiaPadrao ();

			}
			if (v == true) {
				MagiaRed ();

			}
			if (or == true) {
				MagiaOrange ();
			}
			if (ye == true) {
				MagiaYellow ();
			}
			if (gr == true) {
				MagiaGreen ();
			}
			if (bl == true) {
				MagiaBlue ();
			}
			if (pi == true) {
				MagiaPink ();
			}
		} else if (buttonName == "Jump" || buttonName == "JumpRed" || buttonName == "JumpOrange" || buttonName == "JumpYellow" ||
			buttonName == "JumpGreen" || buttonName == "JumpBlue" || buttonName == "JumpPink") {
			SetEstado (Estado.jump); 
			m_charMotor.inputJump = true;
		}
	}
	
	void On_ButtonUp (string buttonName)
	{
		if (buttonName == "Jump") {
			m_charMotor.inputJump = false;
		}

	}

	void EndFire ()
	{
		SetEstado (Estado.idle);
	}
	// Use this for initialization
	void Start ()
	{
		DontDestroyOnLoad(gameObject);
		animation.Play ("idle");
		largura = coracoes [coracaoAtual].pixelInset.width;
		
		//m_charController = GetComponent<CharacterController> ();
		m_charMotor = GetComponent<CharacterMotor> ();
		
		chao = collider.bounds.extents.y;

	}

	void Update ()
	{
		
				if (p == true) {
				MagiaRedGui.SetActive (false);
				MagiaOrangeGui.SetActive (false);
				MagiaYellowGui.SetActive (false);
				MagiaGreenGui.SetActive (false);
				MagiaBlueGui.SetActive (false);
				MagiaPinkGui.SetActive (false);
			
		}
				if (v == true) {
				MagiaRedGui.SetActive (true);
				MagiaOrangeGui.SetActive (false);
				MagiaYellowGui.SetActive (false);
				MagiaGreenGui.SetActive (false);
				MagiaBlueGui.SetActive (false);
				MagiaPinkGui.SetActive (false);
			
		}		if (or == true) {
				MagiaRedGui.SetActive (false);
				MagiaOrangeGui.SetActive (true);
				MagiaYellowGui.SetActive (false);
				MagiaGreenGui.SetActive (false);
				MagiaBlueGui.SetActive (false);
				MagiaPinkGui.SetActive (false);
		
			
		}
				if (ye == true) {
				MagiaRedGui.SetActive (false);
				MagiaOrangeGui.SetActive (false);
				MagiaYellowGui.SetActive (true);
				MagiaGreenGui.SetActive (false);
				MagiaBlueGui.SetActive (false);
				MagiaPinkGui.SetActive (false);
			
		}
		if (gr == true) {
				MagiaRedGui.SetActive (false);
				MagiaOrangeGui.SetActive (false);
				MagiaYellowGui.SetActive (false);
				MagiaGreenGui.SetActive (true);
				MagiaBlueGui.SetActive (false);
				MagiaPinkGui.SetActive (false);
			
		}
		
		if (bl == true) {
							MagiaRedGui.SetActive (false);
				MagiaOrangeGui.SetActive (false);
				MagiaYellowGui.SetActive (false);
				MagiaGreenGui.SetActive (false);
				MagiaBlueGui.SetActive (true);
				MagiaPinkGui.SetActive (false);

		}
		
		if (pi == true) {
							MagiaRedGui.SetActive (false);
				MagiaOrangeGui.SetActive (false);
				MagiaYellowGui.SetActive (false);
				MagiaGreenGui.SetActive (false);
				MagiaBlueGui.SetActive (false);
				MagiaPinkGui.SetActive (true);
			
		}
		
		if (Input.GetKeyDown (KeyCode.M)) {
			Morte ();
		}
		ConferirEstado ();
		transform.position = new Vector3 (transform.position.x, transform.position.y, 0);

		
		if (Input.GetButton ("Run")) {
			m_charMotor.movement.maxForwardSpeed = 15;
		} else
			m_charMotor.movement.maxForwardSpeed = 10;
		

	}
	
	private float chao;

	bool IsGrounded ()
	{
		return Physics.Raycast (transform.position, -Vector3.up, chao);
	}

	public void MagiaRed ()
	{
		Instantiate (bulletred.gameObject, spawnBullet.transform.position, Quaternion.identity);
		audio.PlayOneShot (poder);
	}
	
	public void MagiaOrange ()
	{
		Instantiate (bulletorange.gameObject, spawnBullet.transform.position, Quaternion.identity);
		audio.PlayOneShot (poder);
	}

	public void MagiaYellow ()
	{
		Instantiate (bulletyellow.gameObject, spawnBullet.transform.position, Quaternion.identity);
		audio.PlayOneShot (poder);
	}

	public void MagiaGreen ()
	{
		Instantiate (bulletgreen.gameObject, spawnBullet.transform.position, Quaternion.identity);
		audio.PlayOneShot (poder);
	}
	
	public void MagiaPink ()
	{
		Instantiate (bulletpink.gameObject, spawnBullet.transform.position, Quaternion.identity);
		audio.PlayOneShot (poder);
		
	}

	public void MagiaBlue ()
	{
		Instantiate (bulletblue.gameObject, spawnBullet.transform.position, Quaternion.identity);
		audio.PlayOneShot (poder);
	}
	
	public void MagiaPadrao ()
	{
		Instantiate (bullet.gameObject, spawnBullet.transform.position, Quaternion.identity);
		audio.PlayOneShot (poder);
	}

	public void Magia ()
	{
		
		animation.Blend ("kame");
		Instantiate (bullet.gameObject, spawnBullet.transform.position, Quaternion.identity);
		audio.PlayOneShot (poder);
	}
	
	public void AplicarDano (float dano)
	{
		if (isDead == true)
			return;
		
		float danoAplicado = 0;
			
		while (danoAplicado < dano && !isDead) {
			
			if (coracoes [coracaoAtual].pixelInset.width == largura) {
				coracoes [coracaoAtual].texture = meioCoracao;
				Rect finalWidth = new Rect (coracoes [coracaoAtual].pixelInset.x,
											coracoes [coracaoAtual].pixelInset.y,
											largura / 2,
											coracoes [coracaoAtual].pixelInset.height);
				
				coracoes [coracaoAtual].pixelInset = finalWidth;
				danoAplicado += 0.5f;
				//color.enabled = true;
				StartCoroutine (DanoColor ());
				
				audio.PlayOneShot (Dano);
				audio.Play ();
			} else if (coracoes [coracaoAtual].pixelInset.width == largura / 2) {
				coracoes [coracaoAtual].enabled = false;
				danoAplicado += 0.5f;
				coracaoAtual++;
				
				if (coracaoAtual == 3) {
					isDead = true;
					Morte ();
				}
			}	
		}
		
	}
	
	public void Morte ()
	{
		fundo1.Ligar = true;
		fundo2.Ligar = true;
		AplicarDano (3);
		Controls.SetActive (false);
		audio.PlayOneShot (Dead);
		audio.Play ();
		StartCoroutine (Reset ());
		Instantiate (star.gameObject, spawnStar.transform.position, Quaternion.identity);
		time.SetActive (false);
		Heroi.SetActive (false);

	}
	
	public void RecolherEstrela (int estrelar)
	{
		estrelas += estrelar;
		estrelasGUI.text = estrelas.ToString ();
		estrelasGUIScore.text = estrelas.ToString ();
		estrelasGUI.guiText.fontSize = 66;
		StartCoroutine (Size ());

		audio.PlayOneShot (SoundStar);
		audio.Play ();

		
		if (estrelas >= 1000) {
			AumentarVidas (1);
			estrelas = 0;
			
		}
	}
	
	public void TriggerVilao (int evil)
	{
		ColVilao += evil;
		audio.PlayOneShot (vilao);
					
	}
	
	public void RecolherCrystal (int crystal)
	{
		Crystals += crystal;
		audio.PlayOneShot (crystalSound);
//		if (Crystals == 6) {
//
//			
//		}
		
	}
	
	public void NumeroInimigo (int num)
	{
		NumInimigo += num;
		refGUI.text = NumInimigo.ToString ();
		refGUIScore.text = NumInimigo.ToString ();

		
	}

	public void Empurrar (int em)
	{
		Caixas += em;
		animation.Blend ("empurrar");
		animation.Stop ("idle");
		animation.Stop ("walk");
		animation.Stop ("run");
		
	}
	
	public void MudarFase (int fase)
	{

		Fases += fase;
		audio.PlayOneShot (fas);
		audio.Play ();
		animation.Blend ("power");
		StartCoroutine (Super ());

		
	}
	
	public void SpawnsList (int spawnativo)
	{
		Spawns += spawnativo;
	}
	
	public void AumentarVidas (int vida)
	{ 
		Vidas += vida;
		VidaGui.text = Vidas.ToString ();
		VidaScore.text = Vidas.ToString();
		if (Vidas == 0) {
			GameOver ();
		}
	}
	
	public void RecolherCoracoes (int cor)
	{
		ResetGUI ();
		audio.PlayOneShot (SoundCoracao);
		audio.Play ();
	}
			
	public void GameOver ()
	{
		
		Application.LoadLevel ("gameover");	
	}
	
	public IEnumerator DanoColor ()
	{
		
		yield return new WaitForSeconds(0);
		if (countDown.enabled == true) {
			yield return new WaitForSeconds(0);
			color.enabled = false;
			yield return new WaitForSeconds(0);
			color.enabled = true;
		}
		if (countDown.enabled == false) {
			yield return new WaitForSeconds(0);
			color.enabled = true;
			yield return new WaitForSeconds(0);
			color.enabled = false;	
		}
		
	}

	public IEnumerator Reset ()
	{
		
		yield return new WaitForSeconds(2);
		AumentarVidas (-1);
		Controls.SetActive (true);
		coracaoAtual = 0;
		isDead = false;

		if (countDown.enabled == true) {
			transform.position = spawntime.transform.position;
			Heroi.SetActive (true);
			FundosColor.SetActive (false);
			FundosCinza.SetActive (true);
			PlataformaColor.SetActive (false);
			PlataformaCinza.SetActive (true);
			countDown.enabled = false;
			countDown.timer = 40;
			timeGui.guiText.material = material1;
			timeGui.guiText.fontSize = 55;
	
		} else if (countDown.enabled == false) { 
			if (Spawns == 0) {
				transform.position = spawn.transform.position;
			}
			if (Spawns == 1) {
				transform.position = spawnRed.transform.position;
			}
			if (Spawns == 2) {
				transform.position = spawnOrange.transform.position;
			}
			if (Spawns == 3) {
				transform.position = spawnYellow.transform.position;
			}
			if (Spawns == 4) {
				transform.position = spawnGreen.transform.position;
			}
			if (Spawns == 5) {
				transform.position = spawnBlue.transform.position;
			}
			if (Spawns == 6) {
				transform.position = spawnPink.transform.position;
			}

			FundosCinza.SetActive (true);
			FundosColor.SetActive (false);
			PlataformaColor.SetActive (false);
			PlataformaCinza.SetActive (true);
			Heroi.SetActive (true);
			
		}
	
	
		ResetGUI ();
	}
	
	public IEnumerator Super ()
	{
					
		yield return new WaitForSeconds(3);
		Heroi.SetActive (false);
		yield return new WaitForSeconds(3);
		Application.LoadLevel ("FASE02");
	}
	
	public IEnumerator Size ()
	{
		yield return new WaitForSeconds(0);
		estrelasGUI.guiText.fontSize = 50;
		
	}
	
	private void ResetGUI ()
	{
		for (int i = 0; i< coracoes.Length; i++) {
			coracoes [i].enabled = true;
			coracoes [i].texture = coracao;
			Rect finalWidth = new Rect (coracoes [i].pixelInset.x,
										coracoes [i].pixelInset.y,
										largura,
										coracoes [i].pixelInset.height);
			
			coracoes [i].pixelInset = finalWidth;			
		}
	}
	
}

//variavel Texto (Caixa de texto)
	var gameover: AudioClip;
    var Text : GUIText;
    var spawn : GameObject; 
//variavel privado inicar Tempo (desligado)
    private var starttime = false;
//função iniciar
    function Start()
    {
    //inicirar tempo (ligado)
    starttime = true;
    //se iniciar tempo for igual a ligado
    if (starttime == true)
    {
   //iniciar contagem regressiva 
    StartCoroutine("CountDown");
    }
    }
     //função contagem regressiva
    function CountDown()
    {
    //espearar 1 segundo
    yield WaitForSeconds(1);
    //mostra texto caractere 1
    Text.text = "10";
    //esperar 1 segundo
    yield WaitForSeconds(1);
    //mostra texto caractere Go
    Text.text = "09";
        //espearar 1 segundo
    yield WaitForSeconds(1);
    //mostra texto caractere 1
    Text.text = "08";
    //esperar 1 segundo
    yield WaitForSeconds(1);
    //mostra texto caractere Go
    Text.text = "07";
        //espearar 1 segundo
    yield WaitForSeconds(1);
    //mostra texto caractere 1
    Text.text = "06";
    //esperar 1 segundo
    yield WaitForSeconds(1);
    //mostra texto caractere Go
    Text.text = "05";
        //espearar 1 segundo
    yield WaitForSeconds(1);
    //mostra texto caractere 1
    Text.text = "04";
    //esperar 1 segundo
    yield WaitForSeconds(1);
    //mostra texto caractere Go
    Text.text = "03";
        //espearar 1 segundo
    yield WaitForSeconds(1);
    //mostra texto caractere 1
    Text.text = "02";
    //esperar 1 segundo
    yield WaitForSeconds(1);
    //mostra texto caractere Go
    Text.text = "01";
        //espearar 1 segundo
    yield WaitForSeconds(1);
    Text.text = "";
    audio.PlayOneShot(gameover);
    
transform.position = spawn.transform.position;
yield WaitForSeconds(5);
Application.LoadLevel("MENU");

    }
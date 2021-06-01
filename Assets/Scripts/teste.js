
	var velocidade : float;
    var box : Transform;
     
    function Update () {
     
     var dist : float = Vector3.Distance(box.position, transform.position);
     transform.Translate( 0, 0, velocidade * Time.deltaTime);
     Debug.Log(dist);
     

    }


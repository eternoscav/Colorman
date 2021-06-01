var rotation = 0;
var incremento = 1;

function Update () {

rotation+= incremento;

if(rotation >= 360 || rotation <= 0)
incremento = -incremento;

transform.Rotate(0,0 ,rotation * Time.deltaTime );
}
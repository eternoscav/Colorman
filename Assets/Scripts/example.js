var sound : AudioClip; // drag the sound here

function Update (){
    if(Input.GetKey(KeyCode.Z)){
        // you can use PlayOneShot to specify the sound...
        audio.PlayOneShot(sound);
        // or you can define the sound in the Inspector
        // and use Play like this:
        audio.Play();
    }
}
#pragma strict



function Start () {

}

function Update () {
    if(Input.GetAxis("Horizontal")){
        this.transform.position.x += Input.GetAxis("Horizontal") * Time.deltaTime * 2;
    }
    //if(Input.GetKey(KeyCode.LeftArrow)){
        //this.transform.Rotate(0,180,0);
    }
    //if(Input.GetKey(KeyCode.RightArrow)){
        //this.transform.Rotate(0,0,0);
//    }

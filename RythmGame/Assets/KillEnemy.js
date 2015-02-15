#pragma strict

var explode : GameObject;

function Start () {

}

function OnTriggerEnter2D (collider : Collider2D) {
	Debug.Log(""+collider.tag);
	if(collider.tag != "Player"){
		Destroy(this);
	}
	if(collider.tag == "Enemy"){
			Debug.Log("enemy");
			Instantiate(explode, this.transform.position, this.transform.rotation);
			Destroy(collider.gameObject);
		}
	
	
}
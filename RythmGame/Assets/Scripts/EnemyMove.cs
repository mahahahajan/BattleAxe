using UnityEngine;
using System.Collections;

public class EnemyMove : MonoBehaviour {
	// 1 - Designer variables
	public float random;
	public GameObject player;
	private Transform playerPos;

	/// <summary>
	/// Object speed
	/// </summary>
	public Vector2 speed = new Vector2(10, 10);
	
	/// <summary>
	/// Moving direction
	/// </summary>
	public Vector2 direction;
	
	private Vector2 movement;
	
	void Start()
	{
		player = GameObject.FindGameObjectWithTag("Player");
		playerPos = player.transform;
		//Debug.Log(""+player.ToString);
		random = Random.Range(-2f,2f);
		//Debug.Log ("Player Position is "+ playerPos.position);
		// 2 - Movement
		if(player.transform.localScale.x == -1){
			//Debug.Log("Left");
			direction = new Vector2(-1, 0);
		}
		if(player.transform.localScale.x == 1){
			//Debug.Log("Right");
			direction = new Vector2(1, 0);
		}
		if(direction.x == -1){
			this.transform.Rotate(0,180,0);
		}

		movement = new Vector2(
			(speed.x  + random) * direction.x ,
			(speed.y + random) * direction.y);
	}
	
	void FixedUpdate()
	{
		// Apply movement to the rigidbody
		rigidbody2D.velocity = movement;
	}
}
using UnityEngine;
using System.Collections;

public class CharController : MonoBehaviour {
	
	public float speed = 0.1f;
	public float jumpPower = 50;
	private bool onGround;
	private bool facingLeft = false;
	private bool facingRight = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	if (transform.position.y < -200) 
	{
		//here we reset the gme
			Application.LoadLevel("beforecameraedit");
	}
	if (Input.GetKey("right")) {
			if(facingRight == false)
			{
				transform.Rotate(new Vector3(0, transform.rotation.y - 180.0f, 0));
				facingRight = true;
				facingLeft = false;
			}

			transform.Translate(new Vector3(speed,0,0));
			/*
			if(facingRight)
				transform.Translate(new Vector3(speed,0,0));
			else
				transform.Translate(new Vector3(-speed,0,0));*/

	
	}
	if (Input.GetKey("left")) {

			if(facingLeft == false)
			{
				transform.Rotate(new Vector3(0, transform.rotation.y - 180.0f, 0));
				facingRight = false;
				facingLeft = true;
			}
			transform.Translate(new Vector3(speed,0,0));
/*
			if(facingLeft)
				transform.Translate(new Vector3(speed,0,0));
			else
				transform.Translate(new Vector3(-speed,0,0));*/
	}

	if (Input.GetKey("space") && onGround == true) {

		this.rigidbody.velocity = new Vector3(0, jumpPower,0);

		onGround = false;
	}
		
	if (Input.GetKey("up") && onGround == true) {

		this.rigidbody.velocity = new Vector3(0, jumpPower,0);

		onGround = false;
	}
		
}
	void OnCollisionEnter (Collision collider)
	{
			if (collider.gameObject.tag == "Ground")
				{
					onGround = true;
		}
	}
}

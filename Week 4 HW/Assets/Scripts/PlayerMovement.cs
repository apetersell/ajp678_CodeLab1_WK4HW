using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public KeyCode up;
	public KeyCode down;
	public KeyCode left;
	public KeyCode right;
	public float moveSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		moveBabyMove (up, Vector2.up);
		moveBabyMove (down, Vector2.down);
		moveBabyMove (right, Vector2.right);
		moveBabyMove (left, Vector2.left); 
		
	}

	void moveBabyMove (KeyCode key, Vector2 direction)
	{
		if (Input.GetKey(key)) 
		{
			transform.Translate( direction * moveSpeed * Time.deltaTime);
		}
				
	}

	void OnTriggerEnter2D(Collider2D coll)
	{
		if (coll.gameObject.tag == "DangerBird") 
		{
			Destroy (coll.gameObject); 
			Debug.Log ("Touched Bird");
		}
	}


}

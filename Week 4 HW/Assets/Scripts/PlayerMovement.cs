using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public KeyCode up;
	public KeyCode down;
	public KeyCode left;
	public KeyCode right;
	public float moveSpeed;
	GameObject meter;
	PowerMeter pm;
	public int score;
	public int scorePerBird;

	// Use this for initialization
	void Start () {

		meter = GameObject.Find ("Meter");
		pm = meter.GetComponent<PowerMeter> ();
		DontDestroyOnLoad (this); 
		
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
			pm.increaseMeter (); 
		}

		if (coll.gameObject.tag == "ScoringBird") 
		{
			Destroy (coll.gameObject);
			score = score + scorePerBird;
		}
	}


}

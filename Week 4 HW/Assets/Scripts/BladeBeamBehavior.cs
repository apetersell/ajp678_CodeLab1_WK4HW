using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BladeBeamBehavior : MonoBehaviour {

	public float beamSpeed;
	public float beamTimer; 
	public float beamLimit; 


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		transform.Translate( Vector2.right * beamSpeed * Time.deltaTime);
		beamTimer++;
		if (beamTimer >= beamLimit) {
			Destroy (gameObject);
		}
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerScript : MonoBehaviour {

	GameObject meter;
	PowerMeter pm;

	// Use this for initialization
	void Start () {

		meter = GameObject.Find ("Meter");
		pm = meter.GetComponent<PowerMeter> ();
		
	}
	
	// Update is called once per frame
	void Update () {

		pm.currentPower--; 
		
	}
}

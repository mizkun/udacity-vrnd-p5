using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitTutorial : MonoBehaviour {

	public GameObject tutorial;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnTriggerEnter(Collider collider) {
		Debug.Log ("Enter");
		tutorial.SetActive (true);
	}

	void OnTriggerExit(Collider collider) {
		Debug.Log ("Exit");
		tutorial.SetActive (false);
	}
}



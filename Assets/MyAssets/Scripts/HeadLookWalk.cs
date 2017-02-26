using System.Collections;using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadLookWalk : MonoBehaviour {
	public float velocity = 0.7f;
	public bool isWalking = false;
	public GvrAudioSource walkingSound;

	private CharacterController controller;
	private Clicker cliker = new Clicker ();

	void Start () {
		controller = GetComponent<CharacterController> ();	
	}

	void Update () {
		if (cliker.clicked()) {
			toggleWalking ();
		}
		if (isWalking) {
			controller.SimpleMove (Camera.main.transform.forward * velocity);
		} else {
			walkingSound.Stop ();
		}
	}

	public void toggleWalking () {
		isWalking = !isWalking;
		if (isWalking) {
			walkingSound.Play ();
		} 
	}
}

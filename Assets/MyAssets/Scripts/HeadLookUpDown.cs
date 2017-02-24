using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadLookUpDown : MonoBehaviour {

	public float velocity = 0.7f;
	public float minimumVelocity = 0.002f;
	public bool isWalking;
	public GameObject Tutorial;
	public GameObject BackToHome;


	void Start () {
		isWalking = true;
	}

	void Update () {
		float moveY = Camera.main.transform.forward.y * velocity * Time.deltaTime;
		float newY = transform.position.y + moveY;

		if (Mathf.Abs (moveY) > minimumVelocity && isWalking) {
			transform.position = new Vector3 (transform.position.x, newY, transform.position.z);
		}
		if (newY < -1.0f) {
			Tutorial.SetActive (false);
			BackToHome.SetActive (true);
		} else {
			Tutorial.SetActive (true);
			BackToHome.SetActive (false);
		}
	}
}

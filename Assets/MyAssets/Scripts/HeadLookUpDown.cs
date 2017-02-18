using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadLookUpDown : MonoBehaviour {

	public float velocity = 0.7f;
	public float minimumVelocity = 0.002f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float moveY = Camera.main.transform.forward.y * velocity * Time.deltaTime;
		if (Mathf.Abs (moveY) > minimumVelocity) {
			float newY = transform.position.y + moveY;
			transform.position = new Vector3 (transform.position.x, newY, transform.position.z);
		}
	}
}

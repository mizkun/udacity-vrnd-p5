using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2Museum : MonoBehaviour {

	public GameObject character;
	public float velocity = 30.0f;
	bool inCore;

	void Start () {
		inCore = false;	
	}
	
	void Update () {
		if (inCore) {
			float moveY = velocity * Time.deltaTime;
			character.GetComponent<HeadLookWalk> ().isWalking = false;
			float newY = character.transform.position.y + moveY;
			character.transform.position = new Vector3 (transform.position.x, newY, transform.position.z);
		}
	}

	void OnTriggerEnter(Collider collider) {
		Debug.Log ("EnterCore");
		inCore = true;
	}

	void OnTriggerExit(Collider collider) {
		Debug.Log ("ExitCore");
		inCore = false;
	}
}

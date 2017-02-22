using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class EnterMuseum : MonoBehaviour {

	public static int museum_id;
	
	public GameObject character;
	public float velocity = 30.0f;
	public int this_museum_id;

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
		museum_id = this_museum_id;
	}

	void OnTriggerExit(Collider collider) {
		Debug.Log ("ExitCore");
		inCore = false;
		SceneManager.LoadScene ("Museum");
	}

	public static int getMuseumId () {
		return museum_id;
	}
}

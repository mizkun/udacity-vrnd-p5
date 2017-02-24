using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
using UnityEngine.UI;

public class EnterMuseum : MonoBehaviour {

	public static int museum_id;
	public static string museum_name;
	
	public GameObject character;
	public float velocity = 30.0f;
	public float fadeVelocity = 0.5f;
	public int this_museum_id;
	public string this_museum_name;
	public Image Fadeout;

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

			Color newColor = new Color (Fadeout.color.r, Fadeout.color.g, Fadeout.color.b, Fadeout.color.a + fadeVelocity * Time.deltaTime);
			Fadeout.color = newColor;
			Debug.Log (Fadeout.color);
		}
	}

	void OnTriggerEnter(Collider collider) {
		Debug.Log ("EnterCore");
		inCore = true;
		museum_id = this_museum_id;
		museum_name = this_museum_name;
	}

	void OnTriggerExit(Collider collider) {
		Debug.Log ("ExitCore");
		inCore = false;
		CameraFade.StartAlphaFade(Color.white, false, 2.0f, 0.0f, () => {SceneManager.LoadScene ("Museum");});
		//SceneManager.LoadScene ("Museum");
	}

	public static int getMuseumId () {
		return museum_id;
	}

	public static string getMuseumName () {
		return museum_name;
	}
}

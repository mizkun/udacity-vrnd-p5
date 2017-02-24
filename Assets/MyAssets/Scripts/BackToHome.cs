using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
using UnityEngine.UI;

public class BackToHome : MonoBehaviour {

	public Image progress;
	public float speed;
	public GameObject character;

	private bool isEnter;
	
	void Start () {
		isEnter = false;
		progress.fillAmount = 0.0f;
	}
	
	void Update () {
		if (isEnter) {
			progress.fillAmount += speed * Time.deltaTime;
			if (progress.fillAmount >= 1.0f) {
				Back ();
			}
		}
	}

	public void EnterBackButton () {
		Debug.Log ("Enter Back Button");
		isEnter = true;
		character.GetComponent<HeadLookUpDown> ().isWalking = false;
	}

	public void ExitBackBButton () {
		Debug.Log ("Exit Back Button");
		isEnter = false;
		progress.fillAmount = 0.0f;
		character.GetComponent<HeadLookUpDown> ().isWalking = true;
	}

	public void Back () {
		SceneManager.LoadScene ("Start");
	}
}

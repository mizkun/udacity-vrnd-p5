using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnterWarp : MonoBehaviour {

	public string gateName;
	public string nextScene;
	public bool flg = false;
	public GvrAudioSource warpSound;

	public GameObject Warp;
	public Text[] gateNameTexts;

	private Animator warp_animator;

	void Start () {
		warp_animator = Warp.GetComponent<Animator> ();
		foreach (Text gateNameText in gateNameTexts) {
			gateNameText.text = gateName;
		}
	}
	
	void Update () {
	}

	void OnTriggerEnter(Collider collider) {
		Debug.Log ("Enter");
		EnterEffect ();
	}

	void OnTriggerExit(Collider collider) {
		Debug.Log ("Exit");
		ExitEffect ();
	}

	public void EnterEffect() {
		warp_animator.SetTrigger ("enterTrigger");
		warpSound.Play ();
	}

	public void ExitEffect() {
		warp_animator.SetTrigger ("exitTrigger");

	}

}

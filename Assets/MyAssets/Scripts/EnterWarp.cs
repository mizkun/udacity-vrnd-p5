using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterWarp : MonoBehaviour {

	public string nextScene;
	public bool flg = false;

	public GameObject Warp;

	private Animator warp_animator;

	void Start () {
		warp_animator = Warp.GetComponent<Animator> ();
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
	}

	public void ExitEffect() {
		warp_animator.SetTrigger ("exitTrigger");

	}

}

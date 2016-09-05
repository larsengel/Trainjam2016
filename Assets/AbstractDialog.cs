using UnityEngine;
using System.Collections;

public class AbstractDialog : MonoBehaviour {

	protected bool isTouching;
	protected string message;

	void OnTriggerEnter(Collider other) {
		if (other.name == "Player") {
			GameObject.Find ("talk").GetComponent<SpriteRenderer> ().enabled = true;
			isTouching = true;
		}
	}

	void OnTriggerExit(Collider other) {
		if (other.name == "Player") {
			GameObject.Find ("talk").GetComponent<SpriteRenderer> ().enabled = false;
			isTouching = false;
		}
	}
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Space) && isTouching) {
			DialogSystem.getDialog ().showText (message);
		}

	}

}

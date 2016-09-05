using UnityEngine;
using System.Collections;

public class DialogSystem : MonoBehaviour {

	private TextMesh text;

	// Use this for initialization
	void Start () {
		text = this.GetComponent<TextMesh> ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void showText(string _text) {
		StartCoroutine(setText(_text));
	}


	private IEnumerator setText(string _text) {
		text.text = _text;
		yield return new WaitForSeconds (5);
		if (text.text == _text) {
			text.text = "";
		}
	}

	public static DialogSystem getDialog() {
		return GameObject.Find ("Dialog").GetComponent<DialogSystem>();
	}
}

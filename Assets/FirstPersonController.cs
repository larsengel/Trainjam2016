using UnityEngine;
using System.Collections;

public class FirstPersonController : MonoBehaviour {

	private GameObject player; 
	private GameObject camera;
	private float speed;
	private float turnspeed;

	// Use this for initialization
	void Start () {
		player = this.gameObject;
		camera = GameObject.Find ("Camera");
		speed = 2;
		turnspeed = 150;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 rot = new Vector3 ();

		if (Input.GetKey(KeyCode.Q)) {
			player.transform.Rotate (new Vector3(0,-1,0) * turnspeed * Time.deltaTime);	
		}
		if (Input.GetKey(KeyCode.E)) {
			player.transform.Rotate (new Vector3(0,1,0) * turnspeed * Time.deltaTime);
		}
		/*if (Input.GetAxis ("Mouse Y") < 0) {
			rot.x -= 1;
		}
		if (Input.GetAxis ("Mouse Y") > 0) {
			rot.x += 1;
		}*/

		if (Input.GetKey (KeyCode.W)) {
			player.transform.Translate (Vector3.forward * Time.deltaTime * speed);
		} 
		if (Input.GetKey (KeyCode.S)) {
			player.transform.Translate (Vector3.back * Time.deltaTime * speed);
		} 
		if (Input.GetKey (KeyCode.A)) {
			player.transform.Translate (Vector3.left * Time.deltaTime * speed);
		}
		if (Input.GetKey (KeyCode.D)) {
			player.transform. Translate (Vector3.right * Time.deltaTime * speed);
		} 
	}
}

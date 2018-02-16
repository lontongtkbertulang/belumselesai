using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tempatsampah : MonoBehaviour {
	public float speed = 1.0f;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if(Input.GetKey (KeyCode.A)) {
			GoLeft ();
			// Objek ke kiri
		}
		if(Input.GetKey (KeyCode.D)) {
			GoRight ();
			//Objek ke kanan
		}
		if(Input.GetKey (KeyCode.W)) {
			GoUp ();
			// Objek ke kiri
		}
		if(Input.GetKey (KeyCode.S)) {
			GoDown ();
			//Objek ke kanan
		}
	}

	private void GoLeft() {
		transform.Translate (Vector3.left * speed * Time.deltaTime);
	}

	private void GoRight() {
		transform.Translate (Vector3.right * speed * Time.deltaTime);
	}

	private void GoUp() {
		transform.Translate (Vector3.up * speed * Time.deltaTime);
	}

	private void GoDown() {
		transform.Translate (Vector3.down * speed * Time.deltaTime);
	}
}


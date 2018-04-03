using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraMovementPlayer : MonoBehaviour {

	public float speedMove;
	public float speedRot;
	private Vector3 rot;
	public Rigidbody rb;

	
	// Update is called once per frame
	void Update () {

		Vector3 pos = transform.position;


		if (Input.GetKey ("left")) {
			pos.x += -speedMove * Time.deltaTime;
		}
		if (Input.GetKey ("right")) {
			pos.x += speedMove * Time.deltaTime;
		}

		if (Input.GetKey ("up")) {
			if (pos.y < 400) {
				pos.y += speedMove * Time.deltaTime;
				speedMove = 10f;
			}
		}

		if (Input.GetKey ("down")) {
			pos.y += -speedMove * Time.deltaTime;
		}

		if (Input.GetKey ("w")) {
			pos.z += speedMove * Time.deltaTime;
		}

		if (Input.GetKey ("s")) {
			pos.z += -speedMove * Time.deltaTime;
		}

		if (Input.GetKey ("a")) {
			rot = new Vector3 (0, speedRot * Time.deltaTime, 0);
		}else if (Input.GetKey ("d")) {
			rot = new Vector3 (0, -speedRot * Time.deltaTime, 0);
		} else {
			rot = new Vector3 (0, 0, 0);
		}





		transform.position = pos;
		transform.eulerAngles = transform.eulerAngles - rot;

	}
	void OnTriggerEnter(Collider col){
		speedMove = 0f;
	}
		
}
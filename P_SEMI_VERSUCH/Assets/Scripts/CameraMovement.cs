﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {


	public Transform[] target;
	public float speed;

	private int current;

	// Update is called once per frame
	void Update () {
		
		if (transform.position != target [current].position) {

			Vector3 pos = Vector3.MoveTowards (transform.position, target [current].position, speed * Time.deltaTime);
			GetComponent<Rigidbody> ().MovePosition (pos);
			//transform.Rotate(0, 2*Time.deltaTime, 0);
		} else {
			current = (current + 1) % target.Length;
			}
	}
}

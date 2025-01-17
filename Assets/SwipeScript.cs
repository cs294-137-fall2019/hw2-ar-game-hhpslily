﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeScript : MonoBehaviour {

	Vector2 startPos, endPos, direction; // touch start position, touch end position, swipe direction
	float touchTimeStart, touchTimeFinish, timeInterval; // to calculate swipe time to sontrol throw force in Z direction

	[SerializeField]
	float throwForceInXandY = 2f; // to control throw force in X and Y directions

	[SerializeField]
	float throwForceInZ = 20f; // to control throw force in Z direction

	Rigidbody rb;

	void Start()
	{
		rb = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void Update () {

		// if you touch the screen
		if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Began) {

			// getting touch position and marking time when you touch the screen
			touchTimeStart = Time.time;
			startPos = Input.GetTouch (0).position;
		}

		// if you release your finger
		if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Ended) {

			// marking time when you release it
			touchTimeFinish = Time.time;

			// calculate swipe time interval 
			timeInterval = touchTimeFinish - touchTimeStart;

			// getting release finger position
			endPos = Input.GetTouch (0).position;

			// calculating swipe direction in 2D space
			direction = startPos - endPos;

			// add force to balls rigidbody in 3D space depending on swipe time, direction and throw forces
			rb.isKinematic = false;
			rb.AddForce (- direction.x * throwForceInXandY, - direction.y * throwForceInXandY, throwForceInZ / timeInterval);
			// this.gameObject.transform.Translate(new Vector3(0, -0.001f * direction.y, 0.001f * direction.x));
			Debug.Log(direction);
			// Destroy ball in 4 seconds
			Destroy (gameObject, 3f);

		}
			
	}
}

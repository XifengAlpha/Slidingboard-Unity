﻿using UnityEngine;
using System.Collections;

public class ChangeGravity : MonoBehaviour {

	public float Sensitivity;
	public float Basis;
	public Vector3 GravityDirection;

	// Update is called once per frame
	void Update () {
		float strength = Input.GetAxis("Gravity") * Sensitivity;
		Debug.Log(strength);

		if (strength > 0){
			Physics.gravity = GravityDirection * (Basis + strength);
		} else {
			Physics.gravity = GravityDirection * Basis;
		}
	}
}

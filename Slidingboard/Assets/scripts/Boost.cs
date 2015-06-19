using UnityEngine;
using System.Collections;

public class Boost : MonoBehaviour {
	public float strength;

	void OnTriggerEnter(Collider other) {
		Rigidbody rb = other.GetComponent<Rigidbody>();

		Vector3 forward = rb.velocity.normalized * strength;

		rb.AddForce ( forward );
	}
}

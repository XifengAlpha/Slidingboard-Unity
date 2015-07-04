using UnityEngine;
using System.Collections;

public class TeleportEnter : MonoBehaviour {
	
	public GameObject destination;
	public Vector3 bodyRotate;
	public Vector3 velocityRotate;

	void OnTriggerEnter (Collider other) {

		Quaternion relativeVelocityDirection = Quaternion.FromToRotation (other.gameObject.transform.rotation * Vector3.forward, other.gameObject.GetComponent<Rigidbody>().velocity);

		other.gameObject.transform.position = destination.transform.position;
		other.gameObject.transform.rotation = destination.transform.rotation * Quaternion.Euler(bodyRotate);
		
		Rigidbody rb = other.gameObject.GetComponent<Rigidbody>();

		rb.velocity = relativeVelocityDirection * other.gameObject.transform.rotation * Vector3.forward * rb.velocity.magnitude;
		
	}	
}

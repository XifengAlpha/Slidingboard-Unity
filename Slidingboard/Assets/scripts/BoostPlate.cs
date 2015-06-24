using UnityEngine;
using System.Collections;

public class BoostPlate : MonoBehaviour {

	public float xforce = 0;
	public float yforce = 0;
	public float zforce = 0;

	void OnTriggerEnter (Collider other) {
		other.gameObject.GetComponent<Rigidbody>().AddForce (new Vector3(xforce, yforce, zforce));
	}
}

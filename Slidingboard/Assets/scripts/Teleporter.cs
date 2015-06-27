using UnityEngine;
using System.Collections;

public class Teleporter : MonoBehaviour {

	public GameObject Destination;

	// Use this for initialization
	void OnTriggerEnter ( Collider other ) {
		other.transform.position = Destination.transform.position;
		//other.transform.rotation = Destination.transform.rotation;
	}
}

using UnityEngine;
using System.Collections;

public class Respawn : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if( Input.GetButtonDown ("respawn") ){
			Transform spawnpoint = GameObject.Find ("Playerspawn").transform;
		
			transform.position = spawnpoint.position;
			GetComponent<Rigidbody>().velocity = new Vector3( 0f, 0f, 0f );
			transform.GetChild(0).localRotation = Quaternion.identity;
			transform.rotation = spawnpoint.rotation;
		}
	}
}

using UnityEngine;
using System.Collections;

public class LeftStickMove : MonoBehaviour {

	public float Sensitivity = 1f;
	public float Falloff     = 10f;
	public float MaxSpeed	 = 100f;
	public float Invert		 = -1f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		float turn = Input.GetAxis("LeftHorizontal") * Sensitivity;
		Rigidbody rb = GetComponent<Rigidbody>();

		Quaternion targetRotation = transform.localRotation;
		targetRotation *= Quaternion.Euler (0f, turn, 0f);

		transform.localRotation = targetRotation;

		rb.velocity = Quaternion.Euler (0f, turn, 0f) * rb.velocity;

		if(Input.GetButtonDown("push")) {
			rb.AddForce(transform.localRotation * new Vector3(0f, 0f, MaxSpeed * Invert));
		}
	}
}

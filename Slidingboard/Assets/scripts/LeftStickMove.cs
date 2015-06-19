using UnityEngine;
using System.Collections;

public class LeftStickMove : MonoBehaviour {

	public float Sensitivity = 1f;
	public float Falloff     = 10f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		/*
		float x = Input.GetAxis("LeftHorizontal");
		float y = Input.GetAxis("LeftVertical");
		float rad = Mathf.Atan2(y, x);
		float deg = Mathf.Rad2Deg(rad);
		*/
		Vector3 inputDir = new Vector3(Input.GetAxis("LeftHorizontal"),0f,-Input.GetAxis("LeftVertical"));
		Rigidbody rb = GetComponent<Rigidbody>();
		float currentSpeed = rb.velocity.magnitude;
		/* TODO: it should be easier to change direction
		 *       same-direction accelleration should fall off quickly
		 *       most of your speed should come from boosts (maybe?)
		 */

		Quaternion rotateInputDir = transform.localRotation;
		rb.AddForce( rotateInputDir * inputDir * Sensitivity );
	}
}

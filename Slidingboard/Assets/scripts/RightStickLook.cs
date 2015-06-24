using UnityEngine;
using System.Collections;

public class RightStickLook : MonoBehaviour {

	public float XSensitivity = 1f;
	public float Sensitivity = 1f;
	public float Falloff     = 10f;
	public float MaxSpeed	 = 100f;
	public float Invert		 = -1f;


	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		/** Move the camera up and down
		 *  TODO: Make this reference the correct game object
		 */
		Transform neck = transform.GetChild(0);

		float xRot = Input.GetAxis("RightVertical") * XSensitivity;
		//float yRot = Input.GetAxis("RightHorizontal") * YSensitivity;

		Quaternion targetRotation = neck.localRotation;
		//parentRotation = transform.parent.localRotation;

		targetRotation *= Quaternion.Euler (xRot, 0f, 0f);
		//parentRotation *= Quaternion.Euler (0f, yRot, 0f);
		neck.localRotation = targetRotation;
		//transform.parent.localRotation = parentRotation;

		/** Steering
		 * This is the routine copy-pasted from LeftStickMove,
		 * it's going to turn Mirabella left and right, keeping
		 * her velocity oriented with her localrotation so that you
		 * always move in the direction you are looking.
		 */
		float turn = Input.GetAxis("RightHorizontal") * Sensitivity;
		Rigidbody rb = GetComponent<Rigidbody>();
		
		Quaternion targetVRotation = transform.localRotation;
		targetVRotation *= Quaternion.Euler (0f, turn, 0f);
		
		transform.localRotation = targetVRotation;
		
		rb.velocity = Quaternion.Euler (0f, turn, 0f) * rb.velocity;
		
		if(Input.GetButtonDown("push")) {
			rb.AddForce(transform.localRotation * new Vector3(0f, 0f, MaxSpeed * Invert));
		}
	}
}

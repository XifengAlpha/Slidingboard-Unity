using UnityEngine;
using System.Collections;

public class ylookabout : MonoBehaviour {
	
	public float YSensitivity;

	private Quaternion targetRotation;

	// Use this for initialization
	void Start () {
		targetRotation = transform.localRotation;
	}
	
	// Update is called once per frame
	void Update () {
		float yRot = Input.GetAxis("RightHorizontal") * YSensitivity;

		targetRotation *= Quaternion.Euler (0f, yRot, 0f);
		transform.localRotation = targetRotation;
	
	}
}

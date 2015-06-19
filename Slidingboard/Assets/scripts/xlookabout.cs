using UnityEngine;
using System.Collections;

public class xlookabout : MonoBehaviour {
	
	public float XSensitivity;
	public float YSensitivity;
	
	private Quaternion targetRotation;
	private Quaternion parentRotation;
	
	// Use this for initialization
	void Start () {
		targetRotation = transform.localRotation;
		parentRotation = transform.parent.localRotation;
	}
	
	// Update is called once per frame
	void Update () {
		float xRot = Input.GetAxis("RightVertical") * XSensitivity;
		float yRot = Input.GetAxis("RightHorizontal") * YSensitivity;
		
		parentRotation *= Quaternion.Euler (xRot, 0f, 0f);
		targetRotation *= Quaternion.Euler (0f, yRot, 0f);
		transform.localRotation = targetRotation;
		transform.parent.localRotation = parentRotation;
		
	}
	
}
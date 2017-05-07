using UnityEngine;
using System.Collections;

public class cam_rotate : MonoBehaviour {
	public float rotationRate = 45; // degrees per second
	
	private Quaternion targetOrientation;
	
	void Start()
	{
		// Initialise the target orientation to whatever the initial orientation is
		targetOrientation = transform.rotation;
	}
	
	void Update()
	{
		// Always try to rotate towards the target orientation, whatever it happens to be
		transform.rotation = Quaternion.RotateTowards(transform.rotation, targetOrientation, rotationRate * Time.deltaTime);
	}
	
	void OnMouseUp()
	{
		// Set the target orientation to be looking along the current transform's right vector
		targetOrientation = Quaternion.LookRotation(transform.right);
	}
}

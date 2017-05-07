using UnityEngine;
using System.Collections;

public class GyroControl : MonoBehaviour {

	// Use this for initialization

	private bool gyroEnabled;
	private Gyroscope gyro;
	private GameObject cameraContainer;
	private Quaternion rot;


	void Start () {


		cameraContainer = new GameObject("Camera Container");
		cameraContainer.transform.position = transform.position;
		transform.SetParent (cameraContainer.transform);
		gyroEnabled = EnableGyro ();

	
	}

	private bool EnableGyro()
	{
		if (SystemInfo.supportsGyroscope) {

			gyro = Input.gyro;
			gyroEnabled = true;
			return true;

		}
		return false;

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

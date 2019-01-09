using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroControl : MonoBehaviour {

    /************ https://youtu.be/P5JxTfCAOXo ********************/

    private bool gyroEnabled;
    private Gyroscope gyro;

    private GameObject cameraContainer;
    private Quaternion rot;
    public Transform target;

    // Use this for initialization
    void Start () {
        cameraContainer = new GameObject("Camera Container");
        cameraContainer.transform.position = transform.position;
        transform.SetParent(cameraContainer.transform);
  

        gyroEnabled = EnableGyro();   
		
	}
	
	

    private bool EnableGyro()
    {
        if(SystemInfo.supportsGyroscope)
        {
            gyro = Input.gyro;
            gyro.enabled = true;

            //Vector3 relativePos = target.position - transform.position;
            //cameraContainer.transform.rotation = Quaternion.LookRotation(relativePos, Vector3.up);

            transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, Camera.main.transform.localEulerAngles.y, transform.localEulerAngles.z);

            rot = new Quaternion(0, 0, 1, 0);


            return true;
        }

        return false;
    }

    // Update is called once per frame
    void Update()
    {
        if(gyroEnabled)
        {
            transform.localRotation = gyro.attitude * rot;
        }
        
    }
}

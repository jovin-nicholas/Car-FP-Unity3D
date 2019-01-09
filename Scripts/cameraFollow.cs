using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    /***** https://youtu.be/MFQhpwc6cKE *****/

    //public GameObject car; 
    public Transform target;
	public float lerpRate;
    public Vector3 offset;

    //public bool gameOver;

    // Use this for initialization
    void Start () {
        /*
		offset = transform.position - transform.position;
		gameOver = false;
        */

	}
	
	// Update is called once per frame
	void Update () {
        /*
        if (!gameOver) {
			follow();
			
		}
        */
	}

	void LateUpdate() {
        /*
        Vector3 pos = transform.position;
		Vector3 targetPos = transform.position - offset;
		pos = Vector3.Lerp(pos, targetPos, lerpRate*Time.deltaTime);
        */

        transform.position = target.position + offset;

        //transform.LookAt(target);
        //transform.rotation = target.rotation;
	}
}

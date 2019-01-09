using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AccSlider : MonoBehaviour
{
    public Rigidbody rb;
    float speed;
    float accelerate;
    public float time;
    public float sliderSpeed;
    //public Slider slider;


    // private GameObject cameraContainer;
    //private Quaternion rot;

    void Awake()
    {
        accelerate = speed / time;
    }

    // Use this for initialization
    void Start()
    {
       //cameraContainer = new GameObject("Camera Velocity");
        //cameraContainer.transform.position = transform.position;
        //transform.SetParent(cameraContainer.transform);

        rb = GetComponent<Rigidbody>();

    }

 
    public void Slider_Changed(float newValue)
    {
        //if (newValue > 0)
        //{
        sliderSpeed = newValue;
            speed = 05;
        rb.velocity = new Vector3(0, 0, newValue* speed);
        //rb.AddForce(0, 0, newValue * speed, ForceMode.Acceleration);
        //}

        /*
        else
            rb.velocity = new Vector3(0, 0, newValue);
        */


    }
}

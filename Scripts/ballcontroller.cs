using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballcontroller : MonoBehaviour 
{

//use for initialization
public float speed;
bool started;
public bool gameOver;
Rigidbody rb;
GameObject camera;

void Awake()
{
	rb=GetComponent<Rigidbody>();
	//preloading component
}
	// Use this for initialization
void Start () 
{
	//rb.velocity = new Vector3(speed,0,0);
	started = false;
	gameOver = false;

}
	

	//switching direction of ball on click

        /*
void switchDirection()
{  
	if( rb.velocity.z >0)
	{
	    rb.velocity=new Vector3(speed,0,0);
	}

	else if (rb.velocity.x > 0)
	{
		rb.velocity=new Vector3(0,0,speed);
	}

}
	    // Update is called once per frame
	*/
void Update () 
	{

        //if (Input.GetMouseButtonDown(0)) { }


        /*
	if(!started)
	{
		 if(Input.GetMouseButtonDown(0))
		 {
		 	 rb.velocity=new Vector3(speed,0,0);
		 	 started=true;
		  }		  
	}

	if(!Physics.Raycast(transform.position,Vector3.down,1f))
	{
	 	gameOver=true;
	 	rb.velocity=new Vector3(0,-25f,0);
		camera.GetComponent<cameraFollow>().gameOver=true;
	}
	
	if(started) 
	{
	if(Input.GetMouseButtonDown(0) && !gameOver)
		{
			switchDirection();
		}
    }
	*/
    }
    
}

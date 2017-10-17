﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class input_controller : MonoBehaviour {

    
    //void inputColor()
    //{
    //    if (Input.GetButton("Fire1"))
    //    {
    //        //this.gameObject.GetComponent<Renderer>().material.color = Color.green;
           
    //    } else if (Input.GetButton("Fire2"))
    //    {
    //        this.gameObject.GetComponent<Renderer>().material.color = Color.red;
    //    } else if (Input.GetButton("Fire3"))
    //    {
    //        this.gameObject.GetComponent<Renderer>().material.color = Color.blue;
    //    } else if (Input.GetButton("Jump"))
    //    {
    //        this.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
    //    }
    //}

    void inputMoveJoystick()
    {
        float h = Input.GetAxis("Horizontal");
        //float v = Input.GetAxis("Vertical");
        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.GetComponent<character>().jump();
            this.GetComponent<character>().landed = false;
        }

        //if (((h < 0) && (!this.GetComponent<character>().getdroite())) || ((h > 0) && (!this.GetComponent<character>().getgauche())))
        //{
        //    this.gameObject.transform.position = this.gameObject.transform.position + new Vector3(h * Time.deltaTime * 5, 0, 0);
        //}
        //if (((v < 0) && (!this.GetComponent<character>().getdessus())) || ((v > 0) && (!this.GetComponent<character>().getdessous())))
        //{
        //    this.gameObject.transform.position = this.gameObject.transform.position + new Vector3(0, v * Time.deltaTime * 5, 0);
        //}
        float minX = this.gameObject.GetComponent<character>().CollisionLeft();
        float maxX = this.gameObject.GetComponent<character>().CollisionRight();
        float minY = this.gameObject.GetComponent<character>().CollisionDown();
        float maxY = this.gameObject.GetComponent<character>().CollisionUp();
        if (h != 0)
        {
            //print("input");
            Vector3 pos = this.gameObject.transform.position + new Vector3(h * Time.deltaTime * 5, this.gameObject.GetComponent<character>().getVerticalSpeed(), 0);
            pos.x = Mathf.Clamp(pos.x, minX, maxX);
            pos.y = Mathf.Clamp(pos.y, minY, maxY);
            this.gameObject.transform.position = pos;
        } else
        {
            Vector3 pos = this.gameObject.transform.position;
            pos.x = Mathf.Clamp(this.gameObject.transform.position.x, minX, maxX);
            pos.y = Mathf.Clamp(this.gameObject.transform.position.y + this.gameObject.GetComponent<character>().getVerticalSpeed(), minY, maxY);
            this.gameObject.transform.position = pos;
            
        }
       
    }

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        this.gameObject.GetComponent<Renderer>().material.color = Color.white;
        //inputColor();
        inputMoveJoystick();
	}
}


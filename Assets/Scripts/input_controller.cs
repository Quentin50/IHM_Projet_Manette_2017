using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class input_controller : MonoBehaviour { 

    void inputColor()
    {
        if (Input.GetButton("Fire1"))
        {
            //this.gameObject.GetComponent<Renderer>().material.color = Color.green;
            this.GetComponent<character>().jump();
        } else if (Input.GetButton("Fire2"))
        {
            this.gameObject.GetComponent<Renderer>().material.color = Color.red;
        } else if (Input.GetButton("Fire3"))
        {
            this.gameObject.GetComponent<Renderer>().material.color = Color.blue;
        } else if (Input.GetButton("Jump"))
        {
            this.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        }
    }

    void inputMoveJoystick()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        if (((h < 0) && (!this.GetComponent<character>().getdroite())) || ((h > 0) && (!this.GetComponent<character>().getgauche())))
        {
            this.gameObject.transform.position = this.gameObject.transform.position + new Vector3(h * Time.deltaTime * 5, 0, 0);
        }
        if (((v < 0) && (!this.GetComponent<character>().getdessus())) || ((v > 0) && (!this.GetComponent<character>().getdessous())))
        {
            this.gameObject.transform.position = this.gameObject.transform.position + new Vector3(0, v * Time.deltaTime * 5, 0);
        }
        //if (h != 0 || v != 0)
        //{
        //    Vector3 pos = this.gameObject.transform.position + new Vector3(h * Time.deltaTime * 5, v * Time.deltaTime * 5, 0);
        //    //pos.x = Mathf.Clamp(pos.x, -4, 4);
        //    //pos.y = Mathf.Clamp(pos.y, -4, 4);
        //    this.gameObject.transform.position = pos;
        //}
        //else
        //{


        //}
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.gameObject.GetComponent<Renderer>().material.color = Color.white;
        inputColor();
        inputMoveJoystick();
	}
}


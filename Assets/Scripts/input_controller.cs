using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class input_controller : MonoBehaviour { 

    void inputColor()
    {
        if (Input.GetButton("Fire1"))
        {
            this.gameObject.GetComponent<Renderer>().material.color = Color.green;
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
        if (h != 0 || v != 0)
        {
            Vector3 pos = this.gameObject.transform.position + new Vector3(h, v, 0);
            pos.x = Mathf.Clamp(pos.x, -4, 4);
            pos.y = Mathf.Clamp(pos.y, -4, 4);
            this.gameObject.transform.position = pos;
        } else
        {
            this.gameObject.transform.position = new Vector3(0, 0, -1);
        }
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


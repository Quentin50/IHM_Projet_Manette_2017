using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color : MonoBehaviour {

    public int r, g, b;
	// Use this for initialization
	void Start () {
        r = 255;
        g = 255;
        b = 255;
        Material materialColored = new Material(Shader.Find("Diffuse"));
        this.GetComponent<Renderer>().material = materialColored;
        this.GetComponent<Renderer>().material.color = new Color(r, g, b);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

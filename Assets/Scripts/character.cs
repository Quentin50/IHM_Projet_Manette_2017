using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character : MonoBehaviour {

    bool dessus, dessous, gauche, droite;
    bool possible;

    public void jump()
    {
        if (possible) ;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        float x1 = this.gameObject.GetComponent<Collider2D>().bounds.size.x;
        float x2 = collision.gameObject.GetComponent<Collider2D>().bounds.size.x;
        float y1 = this.gameObject.GetComponent<Collider2D>().bounds.size.y;
        float y2 = collision.gameObject.GetComponent<Collider2D>().bounds.size.y;

        Vector2 pos1 = this.transform.position;
        Vector2 pos2 = this.transform.position;

        dessus = (pos1.y > pos2.y)&&(Mathf.Abs(pos1.x-pos2.x)<Mathf.Abs(x1-x2));
        dessous = (pos1.y < pos2.y)&& (Mathf.Abs(pos1.x - pos2.x) < Mathf.Abs(x1 - x2));
        gauche = (pos1.x < pos2.x)&& (Mathf.Abs(pos1.y - pos2.y) < Mathf.Abs(y1 - y2));
        droite = (pos1.x > pos2.x) && (Mathf.Abs(pos1.y - pos2.y) < Mathf.Abs(y1 - y2)); ;

       
        //if (dessus) {

        //    //this.transform.position = new Vector3(this.transform.position.x,pos2.y + y2+y1,this.transform.position.z);
        //} else if (dessous)
        //{
        //    //this.transform.position = new Vector3(this.transform.position.x, pos2.y - y2 -y1, this.transform.position.z);
        //} else if (gauche)
        //{
        //    //this.transform.position = new Vector3( pos2.x - x2 -x1,this.transform.position.x, this.transform.position.z);
        //} else if (droite)
        //{
        //    //this.transform.position = new Vector3(pos2.x + x2 +x1, this.transform.position.x, this.transform.position.z);
        //}

        print("OntriggerEnter");
    }

    private void updatebools()
    {

    }


    public bool getdessous()
    {
        return dessous;
    }

    public bool getdessus()
    {
        return dessus;
    }

    public bool getgauche()
    {
        return gauche;
    }

    public bool getdroite()
    {
        return droite;
    }

    void gravity()
    {

    }
    // Use this for initialization
    void Start () {
        possible = true;
	}
	
	// Update is called once per frame
	void Update () {

	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character : MonoBehaviour {

    private float height, width;
    public float distance;
    bool dessus, dessous, gauche, droite;
    float time;
    public float gpower;

    public void jump()
    {
        
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


        if (dessus)
        {

            this.transform.position = new Vector3(this.transform.position.x,pos2.y + y2+y1,this.transform.position.z);
            print("dessus");
        }
        else if (dessous)
        {
            this.transform.position = new Vector3(this.transform.position.x, pos2.y - y2 -y1, this.transform.position.z);
            print("dessous");
        }
        else if (gauche)
        {
            this.transform.position = new Vector3( pos2.x - x2 -x1,this.transform.position.x, this.transform.position.z);
            print("gauche");
        }
        else if (droite)
        {
            this.transform.position = new Vector3(pos2.x + x2 +x1, this.transform.position.x, this.transform.position.z);
            print("droite");
        }

        print("OnCollisionEnter");
    }

    void collisionhandler()
    {
        bool ray1 = Physics.Raycast(transform.position + new Vector3(-width,height,0), new Vector3(-1, 0, 0), distance);
        bool ray2 = Physics.Raycast(transform.position + new Vector3(-width, 0, 0), new Vector3(-1, 0, 0), distance);
        bool ray3 = Physics.Raycast(transform.position + new Vector3(-width, -height, 0), new Vector3(-1, 0, 0), distance);

        bool ray4 = Physics.Raycast(transform.position + new Vector3(width, height, 0), new Vector3(1, 0, 0), distance);
        bool ray5 = Physics.Raycast(transform.position + new Vector3(width, 0, 0), new Vector3(1, 0, 0), distance);
        bool ray6 = Physics.Raycast(transform.position + new Vector3(width, -height, 0), new Vector3(1, 0, 0), distance);

        bool ray7 = Physics.Raycast(transform.position + new Vector3(width, -height, 0), new Vector3(0, -1, 0), distance);
        bool ray8 = Physics.Raycast(transform.position + new Vector3(0, -height, 0), new Vector3(0, -1, 0), distance);
        bool ray9 = Physics.Raycast(transform.position + new Vector3(-width, -height, 0), new Vector3(0, -1, 0), distance);

        if (ray1 || ray2 || ray3)
        {
            this.transform.position = new Vector3()
        }

    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        dessus = false;
        dessous = false;
        gauche = false;
        droite = false;
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
        if (!dessus)
        {
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y - time * time * gpower / 2, this.transform.position.z);
            time += Time.deltaTime;
        } else
        {
            time = 0;
        }
        
    }
    // Use this for initialization
    void Start () {
        width = this.gameObject.GetComponent<Collider2D>().bounds.size.x/2;
        height = this.gameObject.GetComponent<Collider2D>().bounds.size.y/2;
        dessus = false;
        time = 0;
	}
	
	// Update is called once per frame
	void Update () {
        gravity();
	}
}

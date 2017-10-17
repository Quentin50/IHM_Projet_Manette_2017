using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character : MonoBehaviour {

    private float height, width;
    public float distance;
    bool dessus, dessous, gauche, droite;
    public bool landed;
    float VerticalSpeed;
    public float g;
    public float jumpPower;
    float time;



    public float CollisionLeft()
    {
        RaycastHit2D hit1 = Physics2D.Raycast(transform.position + new Vector3(-width + 0.1f, height - 0.1f, 0), new Vector3(-1, 0, 0));
        RaycastHit2D hit2 = Physics2D.Raycast(transform.position + new Vector3(-width + 0.1f, 0, 0), new Vector3(-1, 0, 0));
        RaycastHit2D hit3 = Physics2D.Raycast(transform.position + new Vector3(-width + 0.1f, -height + 0.1f, 0), new Vector3(-1, 0, 0));

        Debug.DrawRay(transform.position + new Vector3(-width, height, 0), new Vector3(-1, 0, 0));
        Debug.DrawRay(transform.position + new Vector3(-width, 0, 0), new Vector3(-1, 0, 0));
        Debug.DrawRay(transform.position + new Vector3(-width, -height, 0), new Vector3(-1, 0, 0));

        float val1 = new float(), val2 = new float(), val3 = new float();
        val1 = -100; val2 = -100; val3 = -100;

        if (hit1)
        {

            val1 = hit1.point.x;
            //print("detect 1 !");
        }
        if (hit2)
        {

            val2 = hit2.point.x;
            //print("detect 2 !");
        }
        if (hit3)
        {

            val3 = hit3.point.x;
            //print("detect 3 !");
        }

        float minX = Mathf.Max(val1, val2, val3) + width + 0.35f;

        return minX;
    }

    public float CollisionRight()
    {
        RaycastHit2D hit4 = Physics2D.Raycast(transform.position + new Vector3(width - 0.1f, height - 0.1f, 0), new Vector3(1, 0, 0));
        RaycastHit2D hit5 = Physics2D.Raycast(transform.position + new Vector3(width - 0.1f, 0, 0), new Vector3(1, 0, 0));
        RaycastHit2D hit6 = Physics2D.Raycast(transform.position + new Vector3(width - 0.1f, -height + 0.1f, 0), new Vector3(1, 0, 0));

        Debug.DrawRay(transform.position + new Vector3(width, height, 0), new Vector3(1, 0, 0));
        Debug.DrawRay(transform.position + new Vector3(width, 0, 0), new Vector3(1, 0, 0));
        Debug.DrawRay(transform.position + new Vector3(width, -height, 0), new Vector3(1, 0, 0));

        float val4 = new float(), val5 = new float(), val6 = new float();
        val4 = 100; val5 = 100; val6 = 100;

        if (hit4)
        {

            val4 = hit4.point.x;
            //print("detect 4 !");
        }
        if (hit5)
        {

            val5 = hit5.point.x;
            //print("detect 5 !");
        }
        if (hit6)
        {
            val6 = hit6.point.x;
            //print("detect 6 !");
        }

        float maxX = Mathf.Min(val4, val5, val6) - width - 0.35f;

        return maxX;
    }

    public float CollisionUp()
    {
        RaycastHit2D hit10 = Physics2D.Raycast(transform.position + new Vector3(width - 0.1f, height - 0.1f, 0), new Vector3(0, 1, 0));
        RaycastHit2D hit11 = Physics2D.Raycast(transform.position + new Vector3(0, height - 0.1f, 0), new Vector3(0, 1, 0));
        RaycastHit2D hit12 = Physics2D.Raycast(transform.position + new Vector3(-width + 0.1f, height - 0.1f, 0), new Vector3(0, 1, 0));

        Debug.DrawRay(transform.position + new Vector3(width, height, 0), new Vector3(0, 1, 0));
        Debug.DrawRay(transform.position + new Vector3(0, height, 0), new Vector3(0, 1, 0));
        Debug.DrawRay(transform.position + new Vector3(-width, height, 0), new Vector3(0, 1, 0));

        float val10 = new float(), val11 = new float(), val12 = new float();
        val10 = 100; val11 = 100; val12 = 100;

        if (hit10)
        {
            val10 = hit10.point.y;
            //print("detect 10 !");
        }
        if (hit11)
        {
            val11 = hit11.point.y;
            //print("detect 11 !");
        }
        if (hit12)
        {
            val12 = hit12.point.y;
            //print("detect 12 !");
        }

        float maxY = Mathf.Min(val10, val11, val12) - height - 0.35f;

        return maxY;
    }

    public float CollisionDown()
    {
        RaycastHit2D hit7 = Physics2D.Raycast(transform.position + new Vector3(width - 0.1f, -height + 0.1f, 0), new Vector3(0, -1, 0));
        RaycastHit2D hit8 = Physics2D.Raycast(transform.position + new Vector3(0, -height + 0.1f, 0), new Vector3(0, -1, 0));
        RaycastHit2D hit9 = Physics2D.Raycast(transform.position + new Vector3(-width + 0.1f, -height + 0.1f, 0), new Vector3(0, -1, 0));

        Debug.DrawRay(transform.position + new Vector3(width, -height, 0), new Vector3(0, -1, 0));
        Debug.DrawRay(transform.position + new Vector3(0, -height, 0), new Vector3(0, -1, 0));
        Debug.DrawRay(transform.position + new Vector3(-width, -height, 0), new Vector3(0, -1, 0));

        float val7 = new float(), val8 = new float(), val9 = new float();
        val7 = -100; val8 = -100; val9 = -100;

        if (hit7)
        {
            val7 = hit7.point.y;
            //print("detect 7 !");
        }
        if (hit8)
        {
            val8 = hit8.point.y;
            //print("detect 8 !");
        }
        if (hit9)
        {
            val9 = hit9.point.y;
            //print("detect 9 !");
        }

        float minY = Mathf.Max(val7, val8, val9) + height + 0.35f;

        if (this.gameObject.transform.position.y - minY < 0.02)
        {
            landed = true;
            print("landed true");
            
        } else
        {
            landed = false;
        }
        return minY;
        
    }

    //void collisionhandler()
    //{


    //    RaycastHit2D hit1 = Physics2D.Raycast(transform.position + new Vector3(-width + 0.1f, height - 0.1f, 0), new Vector3(-1, 0, 0));
    //    RaycastHit2D hit2 = Physics2D.Raycast(transform.position + new Vector3(-width + 0.1f, 0, 0), new Vector3(-1, 0, 0));
    //    RaycastHit2D hit3 = Physics2D.Raycast(transform.position + new Vector3(-width + 0.1f, -height + 0.1f, 0), new Vector3(-1, 0, 0));

    //    RaycastHit2D hit4 = Physics2D.Raycast(transform.position + new Vector3(width - 0.1f, height - 0.1f, 0), new Vector3(1, 0, 0));
    //    RaycastHit2D hit5 = Physics2D.Raycast(transform.position + new Vector3(width - 0.1f, 0 , 0), new Vector3(1, 0, 0));
    //    RaycastHit2D hit6 = Physics2D.Raycast(transform.position + new Vector3(width - 0.1f, -height + 0.1f, 0), new Vector3(1, 0, 0));

    //    RaycastHit2D hit7 = Physics2D.Raycast(transform.position + new Vector3(width - 0.1f, -height + 0.1f, 0), new Vector3(0, -1, 0));
    //    RaycastHit2D hit8 = Physics2D.Raycast(transform.position + new Vector3(0, -height + 0.1f, 0), new Vector3(0, -1, 0));
    //    RaycastHit2D hit9 = Physics2D.Raycast(transform.position + new Vector3(-width + 0.1f, -height + 0.1f, 0), new Vector3(0, -1, 0));

    //    RaycastHit2D hit10 = Physics2D.Raycast(transform.position + new Vector3(width - 0.1f, height - 0.1f, 0), new Vector3(0, 1, 0));
    //    RaycastHit2D hit11 = Physics2D.Raycast(transform.position + new Vector3(0 , height - 0.1f, 0), new Vector3(0, 1, 0));
    //    RaycastHit2D hit12 = Physics2D.Raycast(transform.position + new Vector3(-width + 0.1f, height - 0.1f, 0), new Vector3(0, 1, 0));

    //    Debug.DrawRay(transform.position + new Vector3(-width, height, 0), new Vector3(-1, 0, 0));
    //    Debug.DrawRay(transform.position + new Vector3(-width, 0, 0), new Vector3(-1, 0, 0));
    //    Debug.DrawRay(transform.position + new Vector3(-width, -height, 0), new Vector3(-1, 0, 0));

    //    Debug.DrawRay(transform.position + new Vector3(width, height, 0), new Vector3(1, 0, 0));
    //    Debug.DrawRay(transform.position + new Vector3(width, 0, 0), new Vector3(1, 0, 0));
    //    Debug.DrawRay(transform.position + new Vector3(width, -height, 0), new Vector3(1, 0, 0));

    //    Debug.DrawRay(transform.position + new Vector3(width, -height, 0), new Vector3(0, -1, 0));
    //    Debug.DrawRay(transform.position + new Vector3(0, -height, 0), new Vector3(0, -1, 0));
    //    Debug.DrawRay(transform.position + new Vector3(-width, -height, 0), new Vector3(0, -1, 0));

    //    Debug.DrawRay(transform.position + new Vector3(width, height, 0), new Vector3(0, 1, 0));
    //    Debug.DrawRay(transform.position + new Vector3(0, height, 0), new Vector3(0, 1, 0));
    //    Debug.DrawRay(transform.position + new Vector3(-width, height, 0), new Vector3(0, 1, 0));

    //    float   val1 = new float(), val2 = new float(), val3 = new float(), 
    //            val4 = new float(), val5 = new float(), val6 = new float(),
    //            val7 = new float(), val8 = new float(), val9 = new float(), 
    //            val10 = new float(), val11 = new float(), val12 = new float();

    //    val1 = -100; val2 = -100; val3 = -100;
    //    val4 = 100; val5 = 100; val6 = 100;
    //    val7 = -100; val8 = -100; val9 = -100;
    //    val10 = 100; val11 = 100; val12 = 100;


    //    if (hit1)
    //    {
           
    //        val1 = hit1.point.x;
    //        print("detect 1 !");
    //    }
    //    if (hit2)
    //    {
            
    //        val2 = hit2.point.x;
    //        print("detect 2 !");
    //    }
    //    if (hit3)
    //    {
           
    //        val3 = hit3.point.x;
    //        print("detect 3 !");
    //    }



    //    if (hit4)
    //    {
            
    //        val4 = hit4.point.x;
    //        print("detect 4 !");
    //    }
    //    if (hit5)
    //    {
            
    //        val5 = hit5.point.x;
    //        print("detect 5 !");
    //    }
    //    if (hit6)
    //    {
    //        val6 = hit6.point.x;
    //        print("detect 6 !");
    //    }


    //    if (hit7)
    //    {
    //        val7 = hit7.point.y;
    //        print("detect 7 !");
    //    }
    //    if (hit8)
    //    {
    //        val8 = hit8.point.y;
    //        print("detect 8 !");
    //    }
    //    if (hit9)
    //    {
    //        val9 = hit9.point.y;
    //        print("detect 9 !");
    //    }


    //    if (hit10)
    //    {
    //        val10 = hit10.point.y;
    //        print("detect 10 !");
    //    }
    //    if (hit11)
    //    {
    //        val11 = hit11.point.y;
    //        print("detect 11 !");
    //    }
    //    if (hit12)
    //    {
    //        val12 = hit12.point.y;
    //        print("detect 12 !");
    //    }

    //    float minX = Mathf.Max(val1, val2, val3) + width + 0.35f;
    //    float maxX = Mathf.Min(val4, val5, val6) - width - 0.35f;
    //    float minY = Mathf.Max(val7, val8, val9) + height + 0.35f;
    //    float maxY = Mathf.Min(val10, val11, val12) - height - 0.35f;


    //    float X = Mathf.Clamp(this.transform.position.x, minX , maxX );
    //    float Y = Mathf.Clamp(this.transform.position.y, minY, maxY );

    //    this.transform.position = new Vector3(X, Y, -1);
        
        

    //}


    
    
    
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

    public void gravity()
    {
        if (!landed)
        {
            VerticalSpeed = VerticalSpeed - g * Time.deltaTime;
            print(" apply gravity !");
        }
        print("gravity");
    }

    public void jump()
    {
        if (landed)
        {
            landed = false;
            VerticalSpeed = jumpPower;
            print("jump !");

        }
        
    }

    public float getVerticalSpeed()
    {
        return VerticalSpeed;
    }
    // Use this for initialization
    void Start () {
        width = this.gameObject.GetComponent<Collider2D>().bounds.size.x/2;
        height = this.gameObject.GetComponent<Collider2D>().bounds.size.y/2;
        time = 0;
        distance = 15f;
        landed = false;
        VerticalSpeed = 0;
	}
	
	// Update is called once per frame
	void Update () {
        gravity();
        print(landed);
	}
}

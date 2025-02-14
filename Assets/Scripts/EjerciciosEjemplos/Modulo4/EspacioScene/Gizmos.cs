using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gizmos : MonoBehaviour
{
    // Start is called before the first frame update
    //Public Atributes
    public Vector2 point1;
    public Vector2 point2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawLine(point1,point2,Color.red,10);

        //DRAW X
       // Debug.DrawLine(new Vector2(0,0),new Vector2(2,2),Color.red,10);
       // Debug.DrawLine(new Vector2(2,0),new Vector2(0,2),Color.red,10);

       //DRAW RAY
       //Debug.DrawRay(point1,Vector2.up,Color.green,10);

       //Local direccional
       Debug.DrawRay(transform.position,transform.up,Color.green);
       Debug.DrawRay(transform.position,transform.right,Color.red);
       Debug.DrawRay(transform.position,transform.forward,Color.blue);
    }
}

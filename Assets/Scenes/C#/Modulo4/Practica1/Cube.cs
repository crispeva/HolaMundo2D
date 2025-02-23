using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //BASE
        Debug.DrawLine(new Vector3(0,0,0), new Vector3(1,0,0), Color.yellow);
        Debug.DrawLine(new Vector3(0,0,0), new Vector3(0,0,1), Color.yellow);
        Debug.DrawLine(new Vector3(1,0,0), new Vector3(1,0,1), Color.yellow);
        Debug.DrawLine(new Vector3(0,0,1), new Vector3(1,0,1), Color.yellow);

        //CARA1
        Debug.DrawLine(new Vector3(0,0,0), new Vector3(0,1,0), Color.yellow);
         Debug.DrawLine(new Vector3(1,0,0), new Vector3(1,1,0), Color.yellow);
        Debug.DrawLine(new Vector3(0,1,0), new Vector3(1,1,0), Color.yellow);

         //CARA2
        Debug.DrawLine(new Vector3(0,1,0), new Vector3(0,1,1), Color.yellow);
         Debug.DrawLine(new Vector3(0,0,1), new Vector3(0,1,1), Color.yellow);

         //CARA3
         Debug.DrawLine(new Vector3(1,1,0), new Vector3(1,1,1), Color.yellow);
         Debug.DrawLine(new Vector3(1,0,1), new Vector3(1,1,1), Color.yellow);

            //CARA4
            Debug.DrawLine(new Vector3(0,1,1), new Vector3(1,1,1), Color.yellow);

    }
}

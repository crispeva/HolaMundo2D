using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyName : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawLine(new Vector3(2,0,0), new Vector3(2,2,0), Color.red);
        Debug.DrawLine(new Vector3(2,0,0), new Vector3(2,-2,3), Color.red);
        Debug.DrawLine(new Vector3(2,2,0), new Vector3(2,4,3), Color.red);
    }
}

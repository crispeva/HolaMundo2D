using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    //Public Atributes
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        print("target x:"+target.position.x+" y:"+target.position.y+" z:"+target.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target.position);
        
    }
}

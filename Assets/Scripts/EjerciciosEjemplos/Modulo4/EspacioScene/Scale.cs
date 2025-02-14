using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour
{
    //Public Atributes
    public float scaleY;
    // Start is called before the first frame update
    void Start()
    {
        //transform.position = new Vector3(2, transform.position.y, transform.position.z);
        transform.localScale = new Vector3(2, 2, 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

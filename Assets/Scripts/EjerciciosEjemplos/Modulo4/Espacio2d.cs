using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Espacio2d : MonoBehaviour
{
    //Public atributes
    public Transform personaje;
    public Vector3 vector3;
    public float x;
    public float y;
    // Start is called before the first frame update
    void Start()
    {
        vector3= new Vector3(10,10,0);
    }

    // Update is called once per frame
    void Update()
    {
        //personaje.position = vector3;
        personaje.Translate(x*Time.deltaTime,y*Time.deltaTime,0);
        personaje.Rotate(0,0,1);
        //personaje.position= new Vector3(*Time.deltaTime,y*Time.deltaTime,0);
    }
}

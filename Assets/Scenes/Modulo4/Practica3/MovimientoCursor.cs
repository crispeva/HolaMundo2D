using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCursor : MonoBehaviour
{
    //Public Attributes
    public float velocidadMaxima = 6f;
    public float aceleracion = 2f;
    public float desaceleracion = 6f;
    public Transform cubo;

    //Private Attributes
     private Vector3 velocidad = Vector3.zero;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direccion = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        
    if(direccion.magnitude > 0)
    {
        //Aceleracion
        velocidad = Vector3.Lerp(velocidad,direccion.normalized *velocidadMaxima, aceleracion * Time.deltaTime);
    }else
    {
        //Desaceleracion
        velocidad = Vector3.Lerp(velocidad, Vector3.zero, desaceleracion * Time.deltaTime);
    }
    
    cubo.Translate(velocidad * Time.deltaTime);
}
}
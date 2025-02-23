using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMouseRaycast : MonoBehaviour
{
    // Start is called before the first frame update
    //Public Variables
    public Camera camera;
    public Rigidbody CanonTarget=null;
    void FixedUpdate()
    {
      
        //Debug.DrawRay(ray.origin, ray.direction * 100, Color.red);
        if(Input.GetMouseButtonDown(0))
        {
              RaycastHit hit;
              //Creamos un rayo que va desde la posición de la cámara hasta la posición del mouse
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            //Si el rayo choca con un objeto
            if(Physics.Raycast(ray, out hit))
            {
                //Dibujamos una línea desde la posición de la cámara hasta el punto de colisión
                Debug.DrawLine(ray.origin, hit.point, Color.red);
                print("Rayo: "+ray);
                //Desactivamos el objeto con el que chocamos
                //hit.collider.gameObject.SetActive(false);
                CanonTarget=hit.rigidbody;
            }
        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       transform.Rotate(0, 100*Time.deltaTime, 0);
       
    }
    void FixedUpdate()
    {
         RaycastHit hit;
        Debug.DrawRay(transform.position, transform.forward, Color.red);
        //Devuelve un booleano si el rayo colisiona con un objeto y guarda la informacion en hit
          if(Physics.Raycast(transform.position, transform.forward, out hit))
        {
            Debug.DrawRay(transform.position, hit.point, Color.green);

            //Imprime la informacion del transform que colisiona con el rayo
            print("Raycast transform: " + hit.transform.name);
            //Imprime la informacion del collider que colisiona con el rayo
           print("Raycast hit: " + hit.collider.name);
           //Imprime la informacion del punto de colision
           print("Raycast point: " + hit.point);
            //Imprime la informacion de la distancia de colision
           print("Raycast distance: " + hit.distance);
           //Imprime la informacion de la normal de colision
           print("Raycast normal: " + hit.normal);
           //Imprime la informacion del rigibody de colision
           print("Raycast rigibody: " + hit.rigidbody);
        }

        //Es igual pero con mas ratio de colision
        if(Physics.SphereCast(transform.position, 1, transform.forward, out hit))
        {
            
            Debug.DrawRay(transform.position, hit.point, Color.blue);
            print("Shere hit: " + hit.collider.name);
           print("Shere point: " + hit.point);
           print("Shere distance: " + hit.distance);
           print("Shere normal: " + hit.normal);
           print("Shere rigibody: " + hit.rigidbody);
        }
    }
}

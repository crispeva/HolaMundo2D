using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    // Start is called before the first frame update
    //Public Attributes
    [Range(-30, -80)] 
    public float angle = 10;
      [Range(0, 100)] 
       public float power = 10;
    public Transform cannon;
    public CameraMouseRaycast cameraMouseRaycast;
    public Rigidbody cubeProyectile;
    public Rigidbody esphereProyectile;
    public Transform SpawnPoint;
    // Update is called once per frame
    void FixedUpdate()
    {
        //Rota el cilindro del cañon en el eje X para simular la elevación del cañon 
        cannon.rotation = Quaternion.Euler(angle, 0, 0);
        if(cameraMouseRaycast.CanonTarget!=null)
        {
                
                //Movemos el proyectil a la posición del cañon
                cameraMouseRaycast.CanonTarget.transform.position=SpawnPoint.position;
                //Aplicamos una fuerza al proyectil en la dirección del cañon
                cameraMouseRaycast.CanonTarget.AddForce(cannon.up*power,ForceMode.Impulse);
                cameraMouseRaycast.CanonTarget=null;
            
        }
    }
}

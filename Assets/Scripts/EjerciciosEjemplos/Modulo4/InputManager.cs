using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    // Start is called before the first frame update

    //Public Attributes
    public Transform player;
    public float speed = 5.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Input.GetAxis("Horizontal");
        Debug.DrawRay(player.position, Vector3.right * Input.GetAxis("Horizontal") * 5, Color.red);
        print(Input.GetAxis("Horizontal"));
        Debug.DrawRay(player.position, Vector3.forward * Input.GetAxis("Vertical") * 5, Color.blue);
        
        //Mouse Position
        print("Mouse x:"+Input.mousePosition.x+" y:"+Input.mousePosition.y);

        //Axis Fire
        Input.GetButtonUp("Fire1");

        //Mouse ScrollWheel
        print("Mouse ScrollWheel:"+Input.GetAxis("Mouse ScrollWheel"));

        //Movimiento por raton
        player.Translate(Vector3.right * Input.GetAxis("Mouse X") * speed * Time.deltaTime);
        player.Translate(Vector3.forward * Input.GetAxis("Mouse Y") * speed * Time.deltaTime);


        //Movimiento por teclado
        player.Translate(Vector3.right * Input.GetAxis("Horizontal") * speed * Time.deltaTime);
        player.Translate(Vector3.forward * Input.GetAxis("Vertical") * speed * Time.deltaTime);

        //Movimiento por touch
        
        //Input.touchCount; Cantidad de toques
        //Input.GetTouch(0); Devuelve el primer toque
        //Input.GetTouch(0).position; Posicion del primer toque
        //Input.GetTouch(0).deltaPosition; Diferencia de posicion del primer toque
        //Input.GetTouch(0).phase; Estado del primer toque
        //TouchPhase.Began; Comienza el toque
        //TouchPhase.Moved; Se mueve el toque
        //TouchPhase.Stationary; El toque esta quieto
        //TouchPhase.Ended; El toque termina
        //TouchPhase.Canceled; El toque es cancelado
        //Input.GetTouch(0).fingerId; Devuelve el id del dedo que toca
        //Input.GetTouch(0).tapCount; Devuelve la cantidad de toques
        //Input.GetTouch(0).time; Devuelve el tiempo del toque
        //TouchType.Direct; El toque es directo
        //TouchPhase.Stationary; El toque es indirecto
        //TouchType.Indirect; El toque es estacionario

        
    }
}

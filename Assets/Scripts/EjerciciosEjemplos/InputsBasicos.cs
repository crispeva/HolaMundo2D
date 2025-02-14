using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputsBasicos : MonoBehaviour
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
        //Se realizara mientras se presione la tecla
        Input.GetKeyDown(KeyCode.Space);

        //Se realizara mientras se mantenga presionada la tecla
        Input.GetKey(KeyCode.Space);
        //Se realizara cuando se suelte la tecla
        Input.GetKeyUp(KeyCode.Space);


        //Mouse/Touch

        //Se realizara cuando se presione el boton del mouse
        Input.GetMouseButtonDown(0);
        //Se realizara mientras se mantenga presionado el boton del mouse
        Input.GetMouseButton(0);
        //Se realizara cuando se suelte el boton del mouse
        Input.GetMouseButtonUp(0);
;
    }
}

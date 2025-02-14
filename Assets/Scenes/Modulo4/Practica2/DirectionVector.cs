using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //Public Attributes
    public Transform endTransform;
    public Transform initialTransform;
    public float speed = 1.0f;

    //Private Attributes
    private Vector3 _direction;
    // Start is called before the first frame update
    void Start()
    {
        _direction = endTransform.position - initialTransform.position;

        Debug.Log("Direction: " + _direction);
    }

    // Update is called once per frame
    void Update()
    {
        //Calcular la direccion del vector
        _direction = endTransform.position - initialTransform.position;

        //Normalizar el vector para que tenga una magnitud de 1 y mantenga la direccion
        _direction.Normalize();
        Debug.DrawRay(initialTransform.position, _direction, Color.red);
        //Debug.DrawRay(Vector3.zero, _direction, Color.blue);

        //Movimiento del objeto
        initialTransform.Translate(_direction * Time.deltaTime * speed);


        //Rebote dependiendo de la distnaica de un objeto a otro
        if(Vector3.Distance(initialTransform.position, endTransform.position) < 5f)
        {
            speed -= 0.1f;
        }else if(Vector3.Distance(initialTransform.position, endTransform.position) > 5f)
        {
            speed += 0.1f;
        }
    }
}

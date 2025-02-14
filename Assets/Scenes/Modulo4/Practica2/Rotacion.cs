using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacion : MonoBehaviour
{
    //Public Attributes
    public Transform [] planetas = new Transform[3];
    public float  SpeedTierra = 1.0f;
    public float  SpeedMarte = 1.0f;    
    public float  SpeedSaturno = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        SpeedTierra = 30.0f;
        SpeedMarte = 40.0f;    
        SpeedSaturno = 50.0f;
    }

    // Update is called once per frame
    void Update()
    {
         for (int i = 0; i < 3; i++)
        {
            planetas[i].Rotate(0.4f, 0.4f, 0);
        } 
        planetas[0].RotateAround(transform.position, Vector3.up, SpeedTierra * Time.deltaTime);
        Debug.DrawLine(planetas[0].position, transform.position, Color.red);

        planetas[1].RotateAround(transform.position, Vector3.up, SpeedSaturno * Time.deltaTime);
        Debug.DrawLine(planetas[1].position, transform.position, Color.green);

        planetas[2].RotateAround(transform.position, Vector3.up, SpeedMarte * Time.deltaTime);
        Debug.DrawLine(planetas[2].position, transform.position, Color.blue);
    }
}

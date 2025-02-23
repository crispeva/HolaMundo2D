using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
        //Public Attributes
    public Transform player;
    public Transform camaraTransform;
    public float speed = 5.0f;
    public float rotationSpeed = 5.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
             player.Translate(Vector3.right * Input.GetAxis("Horizontal") * speed * Time.deltaTime);
        player.Translate(Vector3.forward * Input.GetAxis("Vertical") * speed * Time.deltaTime);

        //Camera roation
        //camaraTransform.RotateAround(transform.position, Vector3.up, Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime);

        //Plater Rotation

        transform.Rotate(Vector3.up, Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime);


        //Zoom camera
        camaraTransform.LookAt(transform.position);
        camaraTransform.Translate(camaraTransform.forward * Input.GetAxis("Mouse ScrollWheel") * speed * Time.deltaTime);
    }
}

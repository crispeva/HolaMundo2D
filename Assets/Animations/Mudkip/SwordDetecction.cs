using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordDetecction : MonoBehaviour
{
    [SerializeField] private float force = 10f;
    // Start is called before the first frame update
    void Start()
    {
        force = 100f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void voidOnTriggerEnter(Collider2D collision)
    {
        if(collision.GetComponent<Rigidbody2D>() != null)
        {
            //collision.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 10), ForceMode2D.Impulse);
            Vector2 direction = collision.transform.position - transform.position;
            //direction.Normalize();
            collision.GetComponent<Rigidbody2D>().AddForce(direction * force, ForceMode2D.Impulse);
        }
    }
}

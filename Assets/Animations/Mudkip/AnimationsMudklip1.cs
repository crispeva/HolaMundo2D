using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor.Tilemaps;
using UnityEngine;

public class AnimationsMudkip : MonoBehaviour
{
    // Start is called before the first frame update
   [SerializeField] private Animator MudkipAnimator;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Move Right
        if (Input.GetKey( KeyCode.RightArrow))
        {
            MudkipAnimator.SetBool("RunMudkip", true);
            transform.Translate(Vector3.right * 1f * Time.deltaTime);
        }
        else if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            MudkipAnimator.SetBool("RunMudkip", false);
        }

        //Move Left
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            MudkipAnimator.SetBool("RunMudkip", true);
            transform.Translate(Vector3.left * 1f * Time.deltaTime);
            GetComponent<SpriteRenderer>().flipX = true;
            
        }
        else if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            MudkipAnimator.SetBool("RunMudkip", false);
            GetComponent<SpriteRenderer>().flipX = false;
        }
        
        //Attack
        if (Input.GetKeyDown( KeyCode.Mouse0))
        {
            MudkipAnimator.SetTrigger("AttackMudkip");
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("AgujeroNegro"))
        {
            MudkipAnimator.SetTrigger("Hit");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RobotAnimatorController : MonoBehaviour
{
    // Start is called before the first frame update
    //Public Attributes
    //Private Attributes
    [SerializeField] private Animator _robotAnimator;

    // Update is called once per frame
    void Update()
    {
        //Check if the left arrow key is pressed
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            _robotAnimator.SetBool("Run", true);
        }
        else if(Input.GetKeyUp(KeyCode.RightArrow))
        {
            _robotAnimator.SetBool("Run", false);
        }

        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            _robotAnimator.SetTrigger("Attack");
        }
        if(Input.GetKeyDown(KeyCode.Return))
        {
            _robotAnimator.SetTrigger("hit");
        }
    }
}

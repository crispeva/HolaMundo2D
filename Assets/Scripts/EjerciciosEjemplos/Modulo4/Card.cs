using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    //Public Attributes
    public string CardName;
    public int cost;
    //Private Attributes


    public void UseCard(){
        print("Usaste la carta "+CardName+ " Que cuesta "+cost);
    }

    
   
}

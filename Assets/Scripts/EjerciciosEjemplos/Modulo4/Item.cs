using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    // Public Attributes
    public string itemName;
    public float price;
    //Private Attrbutes
    private int _count;

    //Public Method
    public void Use(){
            print("You used "+ itemName);
    }
}

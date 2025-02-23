using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Public Attributes
    public string PlayerName;
    public  Card [] mallet = new Card[3];

    public bool Play;
void Start(){
    Play=false;
}
    void Update(){

        if(Play){
            PlayCard();
        }
    }
      public void PlayCard(){
        print("Has jugado una carta");

        mallet[UnityEngine.Random.Range(0,3)].UseCard();

        Play=false;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class soun_controler : MonoBehaviour
{
    public GameObject putar1;
    public AudioSource lagu;
    public void muncul(){
        if (!lagu.mute){
            lagu.mute = true;
        }
    }
    public void hilang(){
        if (lagu.mute){
            lagu.mute = false;
        }
    }
    public void masuk(){
        if (!lagu.mute){
            lagu.mute = true;
        }
    }
    public void keluar(){
        if (lagu.mute&&putar1.activeSelf){
            lagu.mute = false;
        }else{
            lagu.mute = true;   
        }
    }
}

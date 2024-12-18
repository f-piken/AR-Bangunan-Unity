using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class kembali : MonoBehaviour
{
    public GameObject menu;
    public GameObject x;
    public string a; 
    public void balek(){
        menu.SetActive(true);
        x.SetActive(false);
    }
    public void masuk(){
        menu.SetActive(false);
        x.SetActive(true);
    }
    public void pindah(){
        SceneManager.LoadScene(a);
    }
}

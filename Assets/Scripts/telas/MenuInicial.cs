using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement; 
using UnityEngine;

public class MenuInicial : MonoBehaviour{

    public void Jogar(){
        SceneManager.LoadScene("Jogar");
    }

    public void Controles(){
        print("1");
        SceneManager.LoadScene("Controles");
    }

    public void Creditos(){
        print("2");
        SceneManager.LoadScene("Creditos");
    }

    public void Menu(){
        print("3");
        SceneManager.LoadScene("Menu");
    }
}

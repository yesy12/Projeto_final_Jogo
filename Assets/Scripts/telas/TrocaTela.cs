using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class TrocaTela : MonoBehaviour{
    public void Jogar(){
        SceneManager.LoadScene("Jogar");
    }

    public void Controles(){

        SceneManager.LoadScene("Controles");
    }

    public void Creditos(){
        SceneManager.LoadScene("Creditos");
    }

    public void Creditos2(){
        SceneManager.LoadScene("Creditos2");
    }

    public void Menu(){
        SceneManager.LoadScene("Menu");
    }
}

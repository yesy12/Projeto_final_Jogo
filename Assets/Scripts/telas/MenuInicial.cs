using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement; 
using UnityEngine;

public class MenuInicial : MonoBehaviour{
    void Start(){
        
    }

    void Update(){
        
    }

    public void Jogar(){
        SceneManager.LoadScene("Albion");
    }

    public void Controles(){
        SceneManager.LoadScene("Controles");
    }

    public void Creditos(){
        SceneManager.LoadScene("Creditos");
    }

    public void Voltar(){
        SceneManager.LoadScene("MenuInicial");
    }
}

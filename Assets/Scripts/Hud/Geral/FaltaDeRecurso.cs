using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FaltaDeRecurso : MonoBehaviour{

    public GameObject messagePanelRecurso;
    public Text messagePanelRecursoText;
    public static bool messageRecursoTrue;

    public static string textoGlobal;


    void Awake(){
        setTextoGlobal("null");
    }

    void Update(){
        verificarMessageTrue();
        setMessageRecursoFaltanteString(returnTextoGlobal());      
    }

    public void verificarMessageTrue(){
        if(returnMessageRecursoTrue() == true){
            OpenMessagePanel();
        }
        else{
            CloseMessagePanel();
        }
    }

    public void OpenMessagePanel(){
        messagePanelRecurso.SetActive(true);
    }

    public void CloseMessagePanel(){
        messagePanelRecurso.SetActive(false);
    }

    public static void setMessageRecursoTrue(bool selecao){
        messageRecursoTrue = selecao;
    }

    public bool returnMessageRecursoTrue(){
        return messageRecursoTrue;
    }

    public static void setTextoGlobal(string texto){
        textoGlobal = texto;
    }

    public static string returnTextoGlobal(){
        return textoGlobal;
    }

    public static void setMessageRecursoFaltante(string item){
        if(item  == "1"){
            setTextoGlobal("- Você não tem espada -");
        }
        else if(item  == "2"){
            setTextoGlobal("- Você não tem machado -");
        }
        else if(item  == "3"){
            setTextoGlobal("- Falta Poções de Vida -");
        }
        else if(item == "4"){
            setTextoGlobal("- Falta Poções de Stamina -");
        }
        else if(item == "5"){
           setTextoGlobal("- Falta Poções de Xp -");
        }
        else if(item == "6"){
           setTextoGlobal("- Você não tem bau -");
        }
    }

    public void setMessageRecursoFaltanteString(string texto){
        messagePanelRecursoText.text = texto;
    }

}

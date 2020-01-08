using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NivelText : MonoBehaviour{

    [SerializeField] Text nivelText;
    public static int nivelNum;

    public string textoGlobal;

    void Start(){
        setNivelNum(1);
    }

    void Update(){
        setTextoGlobal();
        setNivelNumHud(returnTextoGlobal());
    }

    void setTextoGlobal(){
        textoGlobal = returnNivelNum();
    }

    string returnTextoGlobal(){
        return textoGlobal;
    }

    public static void somaNivelTextNum(int quantidade){
        nivelNum += quantidade;
    }

    public static void setNivelNum(int quantidade){
        nivelNum = quantidade;
    }

    public void setNivelNumHud(string texto){
        nivelText.text = "Nível "+ texto;
    }

    public static string returnNivelNum(){
        return nivelNum.ToString();
    }

}


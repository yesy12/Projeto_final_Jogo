using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class XPText : MonoBehaviour{

    [SerializeField] Text xpPercentualText;
    public static string xpPercentual;

    static int contadorMostrarXP = 0;

    public string textoGlobal;

    void Start(){
        setXpPercentual("0");
    }

    void Update(){
        setTextoGlobal(returnXpPercentual());
        setXpPercentualHud(returnTextoGlobal());
    }

    void setTextoGlobal(string texto){
        if(LifeNoPercent.returnMostrarVidaBool()){
            textoGlobal = texto;
        }
        else{
            textoGlobal = returnXpPercentual() + "%/100%";
        }
    }

    string returnTextoGlobal(){
        return textoGlobal;
    }

    public static void setXpPercentual(string texto){
        xpPercentual = texto;
    }

    public void setXpPercentualHud(string texto){
        xpPercentualText.text = texto;
    }

    public static string returnXpPercentual(){
        return xpPercentual;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeText : MonoBehaviour{

    [SerializeField] Text lifeText;
    public static string lifePercentual;

    public string textoGlobal;

    static int contadorMostrarVida;

    void Start(){
        setLifePercentual("0");
    }

    void Update(){  
        setTextoGlobal(returnLifePercentual());
        setLifePercentualHud(returnTextoGlobal());
    }
    void setTextoGlobal(string texto){
        if(LifeNoPercent.returnMostrarVidaBool()){
            textoGlobal = texto;
        }
        else{
            textoGlobal = returnLifePercentual() + "%/100%";
        }
    }

    string returnTextoGlobal(){
        return textoGlobal;
    }

    public static void setLifePercentual(string texto){
        lifePercentual = texto;
    }

    public void setLifePercentualHud(string texto){
        lifeText.text = texto;
    }

    public static string returnLifePercentual(){
        return lifePercentual;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StaminaText : MonoBehaviour{

    [SerializeField] Text staminaText;
    public static string staminaPercentual;
    static int contadorMostrarStamina;

    public string textoGlobal;

    void Start(){
        setStaminaPercentual("0");
    }

    void Update(){
        setTextoGlobal(returnStaminaPercentual());
        setStaminaPercentualHud(returnTextoGlobal());
    }


    void setTextoGlobal(string texto){
        if(StaminaNoPercent.returnMostrarStaminaBool()){
            textoGlobal = texto;
        }
        else{
            textoGlobal = returnStaminaPercentual() + "%/100%";
        }
    }

    string returnTextoGlobal(){
        return textoGlobal;
    }

    public static void setStaminaPercentual(string texto){
        staminaPercentual = texto;
    }

    public void setStaminaPercentualHud(string texto){
        staminaText.text = texto;
        return ;
    }

    public static string returnStaminaPercentual(){
        return staminaPercentual;
    }

}

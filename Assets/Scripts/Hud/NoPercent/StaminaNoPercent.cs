using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaminaNoPercent : MonoBehaviour{

    public static float StaminaAtual;
    public static float StaminaMaximo;

    static int contadorMostrarStaminaDez = 0;

    public static bool mostraStaminaBool;

    void Awake(){
        setMostrarStaminaBool(false);
    }

    void Start(){
        setStaminaAtual(100);
        setStaminaMaximo(100);
    }

    void Update(){
        igualarStamina();
        passarStaminaTexto();
        //MostraStamina();
        danoStamina();
    }

    static void igualarStamina(){
        if(returnStaminaAtual() > returnStaminaMaximo()){
            StaminaAtual = StaminaMaximo;
        }
    }

    void passarStaminaTexto(){
        if(returnMostrarStaminaBool() == false){
            StaminaText.setStaminaPercentual( ((returnStaminaAtual()/returnStaminaMaximo())*100).ToString("F0") );
        }
    }
 
    public static void MostrarStamina(){
        if(returnMostrarStaminaBool() == true){
            StaminaText.setStaminaPercentual( returnStaminaAtual().ToString() + "/" + returnStaminaMaximo().ToString() );
        }   
    }

    public static void setMostrarStaminaBool(bool situacao){
        mostraStaminaBool = situacao;
    }

    public static bool returnMostrarStaminaBool(){
        return mostraStaminaBool;
    }

    public static void somarStamina(int quantidade){
        StaminaAtual += quantidade;
        igualarStamina();
    }

    public static void tirarStamina(int quantidade){
        if(quantidade > 0 && StaminaAtual >= 0){
            StaminaAtual -= quantidade;
        }
    }

    static void danoStamina(){
        if(StaminaAtual < 10){
            contadorMostrarStaminaDez +=1;

            if(contadorMostrarStaminaDez == 5){

                if(LifeNoPercent.returnLifeAtual() > 0){
                    LifeNoPercent.tirarVida(1);
                }
                contadorMostrarStaminaDez=0;
            } 
        }
    }

    public static float returnStaminaAtual(){
        return StaminaAtual;
    }

    public static float returnStaminaMaximo(){
        return StaminaMaximo;
    }

    public static void setStaminaAtual(int quantidade){
        StaminaAtual = quantidade;
    }

    public static void setStaminaMaximo(int quantidade){
        StaminaMaximo = quantidade;
    }
}
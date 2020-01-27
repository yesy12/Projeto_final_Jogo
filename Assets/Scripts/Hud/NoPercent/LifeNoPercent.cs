using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeNoPercent : MonoBehaviour{

    public static float LifeAtual; 
    public static float LifeMaximo;
    public static bool mostraVidaBool;

    void Awake(){
        setMostrarVidaBool(false);
    }

    void Start(){
        setVidaAtual(100);
        setVidaMaximo(100);
    }

    void Update(){
        MostrarVida();
        igualarVida();
        passarVidaTexto();
        morreu();
    }

    static void igualarVida(){
        if(returnLifeAtual() > returnLifeMaximo()){
            LifeAtual = LifeMaximo;
        }
    }

    void passarVidaTexto(){
        if(returnMostrarVidaBool() == false){
            LifeText.setLifePercentual( ((returnLifeAtual()/returnLifeMaximo())*100).ToString("F0") );
        }       
    }

    public static void MostrarVida(){
        if(returnMostrarVidaBool() == true){
            var texto = returnLifeAtual().ToString() + "/" + returnLifeMaximo().ToString();
            LifeText.setLifePercentual(texto);
        }   
    }

    public static void setMostrarVidaBool(bool situacao){
        mostraVidaBool = situacao;
    }

    public static bool returnMostrarVidaBool(){
        return mostraVidaBool;
    }

    public static void somarVida(int quantidade){
        LifeAtual += quantidade;
        igualarVida();
    }

    public static void tirarVida(int quantidade){
        if(quantidade > 0 && returnLifeAtual() >= 0){
            LifeAtual -= quantidade;
            morreu();
        }
    }

    public static void setVidaAtual(int quantidade){
        LifeAtual = quantidade;
    }

    public static void setVidaMaximo(int quantidade){
        LifeMaximo = quantidade;
    }

    public static float returnLifeAtual(){
        return LifeAtual;
    }

    public static float returnLifeMaximo(){
        return LifeMaximo;
    }
    
    static void morreu(){
        if(LifeAtual <= 0){
            print("Você morreu");
        }
    }
}
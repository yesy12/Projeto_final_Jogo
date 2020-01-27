using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XpNoPercent : MonoBehaviour{

    public static int nivelAtual;
    public static float xpAtual;
    public static float xpMaximo;

    public static bool mostrarXpBool;

    void Awake(){
        setNivelAtual(1);
    }

    void Update(){
        xpPorNivel();
        passarXpTexto();
        passarNivel();
        MostrarXp();
    }
    
    static void passarXpTexto(){
        if(returnMostrarXpBool() == false){
            XPText.setXpPercentual( (returnXpAtual()/returnXpMaximo()*100).ToString("F0") );
        }
    }
  
    public static void MostrarXp(){
        if(returnMostrarXpBool() == true){
            XPText.setXpPercentual( returnXpAtual().ToString() + "/" + returnXpMaximo().ToString() ) ;
        }
    }

    public static void setMostrarXpBool(bool situacao){
        mostrarXpBool = situacao;
    }

    public static bool returnMostrarXpBool(){
        return mostrarXpBool;
    }

    static void xpPorNivel(){
        if(returnNivelAtual() == 1){
            setXpMaximo(100);      
        }
        else if(returnNivelAtual() == 2){
            setXpMaximo(200);
        }
        else if(returnNivelAtual() == 3){
            setXpMaximo(300);
        }
        else if(returnNivelAtual() == 4){
            setXpMaximo(400);
        }       
        else if(returnNivelAtual() == 5){
            setXpMaximo(500);
        }        
        else if(returnNivelAtual() == 6){
            setXpMaximo(600);
        }        
        else if(returnNivelAtual() == 7){
            setXpMaximo(700);
        }        
        else if(returnNivelAtual() == 8){
            setXpMaximo(800);
        }        
        else if(returnNivelAtual() == 9){
            setXpMaximo(900);
        }
        else if(returnNivelAtual() == 10){
            setXpMaximo(1000);
        }
        else if(returnNivelAtual() == 11){
            setXpMaximo(1100);
        }
        else if(returnNivelAtual() == 12){
            setXpMaximo(1200);
        }
        else if(returnNivelAtual() == 13){
            setXpMaximo(1300);
        }
        else if(returnNivelAtual() == 14){
            setXpMaximo(1400);
        }
        else if(returnNivelAtual() == 15){
            setXpMaximo(1500);
        }
        else if(returnNivelAtual() == 16){
            setXpMaximo(1600);
        }
    }
    
    void passarNivel(){
        if(returnXpAtual() >= returnXpMaximo()){
            NivelText.somaNivelTextNum(1);
            XPText.setXpPercentual("0");
            setXpAtual(0);
            somaNivelAtual(1);
        }
    }

    public static int returnNivelAtual(){
        return nivelAtual;
    }

    public static void setXpAtual(int quantidade){
        xpAtual = quantidade;
    }
    
    public static void setXpMaximo(int quantidade){
        xpMaximo = quantidade;
    }

    public static void setNivelAtual(int quantidade){
        nivelAtual = quantidade;
    }

    static void somaNivelAtual(int quantidade){
        nivelAtual += quantidade;
    }

    public static void somaXp(int quantidade){
        xpAtual += quantidade;
    }

    public static float returnXpAtual(){
        return xpAtual;
    }

    public static float returnXpMaximo(){
        return xpMaximo;
    }
}
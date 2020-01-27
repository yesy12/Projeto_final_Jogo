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
        XPText.setXpPercentual("0");
    }

    void Update(){
        passarXpTexto();
        xpPorNivel();
        passarNivel();
        MostrarXp();
    }

    static void passarXpTexto(){
        if(returnMostrarXpBool() == false){
            if(returnXpAtual() > 0){
                XPText.setXpPercentual( (returnXpAtual()/returnXpMaximo()*100).ToString("F0") );
            }
            else{
                XPText.setXpPercentual( "0");
            }
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
        return ;
    }

    static void aumentarDanoStaminaLife(){
        var dano1 = personagem.returnDanoArma1Personagem();
        var dano2 = personagem.returnDanoArma2Personagem();
        var staminaAtual = StaminaNoPercent.returnStaminaAtual();
        var staminaMaximo = StaminaNoPercent.returnStaminaMaximo();
        var lifeAtual = LifeNoPercent.returnLifeAtual();
        var lifeMaximo = LifeNoPercent.returnLifeMaximo();
        var danoMais = 0;
        var staminaMais = 0;
        var lifeMais = 0;

        if(returnNivelAtual() == 2){
            danoMais = 1;
            staminaMais = 10;
            lifeMais = 10;
        }
        else if(returnNivelAtual() == 3){
            danoMais = 2;
            staminaMais = 20;
            lifeMais = 20;
        }
        else if(returnNivelAtual() == 4){
            danoMais = 3;
            staminaMais = 30;
            lifeMais = 30;
        }
        else if(returnNivelAtual() == 5){
            danoMais = 1;
            staminaMais = 40;
            lifeMais = 40;
        }
        else if(returnNivelAtual() == 6){
            danoMais = 2;
            staminaMais = 50;
            lifeMais = 50;
        }
        else if(returnNivelAtual() == 7){
            danoMais = 3;
            staminaMais = 60;
            lifeMais = 60;
        }
        else if(returnNivelAtual() == 8){
            danoMais = 1;
            staminaMais = 70;
            lifeMais = 70;
        }
        else if(returnNivelAtual() == 9){
            danoMais = 2;
            staminaMais = 80;
            lifeMais = 80;
        }
        else if(returnNivelAtual() == 10){
            danoMais = 3;
            staminaMais = 90;
            lifeMais = 90;
        }
        else if(returnNivelAtual() == 11){
            danoMais = 1;
            staminaMais = 100;
            lifeMais = 100;
        }
        else if(returnNivelAtual() == 12){
            danoMais = 2;
            staminaMais = 110;
            lifeMais = 110;
        }
        else if(returnNivelAtual() == 13){
            danoMais = 3;
            staminaMais = 120;
            lifeMais = 120;
        }
        else if(returnNivelAtual() == 14){
            danoMais = 1;
            staminaMais = 130;
            lifeMais = 130;
        }
        else if(returnNivelAtual() == 15){
            danoMais = 2;
            staminaMais = 140;
            lifeMais = 140;
        }
        else if(returnNivelAtual() == 16){
            danoMais = 3;
            staminaMais = 150;
            lifeMais = 150;
        }

        personagem.setDanoArma1Personagem(dano1 + danoMais);
        personagem.setDanoArma1Personagem(dano2 + danoMais);

        StaminaNoPercent.setStaminaAtual((int)staminaAtual + staminaMais);
        StaminaNoPercent.setStaminaMaximo((int)staminaMaximo + staminaMais);

        LifeNoPercent.setVidaAtual((int)lifeAtual + lifeMais);
        LifeNoPercent.setVidaMaximo((int)lifeMaximo + lifeMais);
    }

    void passarNivel(){
        if(returnXpAtual() > returnXpMaximo()){
            
            while (returnXpAtual() > 0){
                xpPorNivel();
                
                if(returnXpAtual() > returnXpMaximo()){
                    setXpAtual((int)returnXpAtual() - (int)returnXpMaximo());
                    somaNivelAtual(1);
                    NivelText.somaNivelTextNum(1);
                    XPText.setXpPercentual(returnXpAtual().ToString());
                    aumentarDanoStaminaLife();
                }
                else{
                    break;
                }
            }

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
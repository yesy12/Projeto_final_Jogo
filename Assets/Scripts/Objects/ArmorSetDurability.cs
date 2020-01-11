using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random=UnityEngine.Random;

public class ArmorSetDurability : MonoBehaviour{
    
    public int durability;
    public int level;

    public int dano;

    void Awake(){
        setLevel();
        setLevelDurability();
        setLevelDano();
    }

    void setLevelDurability(){      
        if(returnLevel() == 1){
            setDurability(100);
        }
        else if(returnLevel() == 2){
            setDurability(200);
        }
        else if(returnLevel() == 3){
            setDurability(300);
        }
        else if(returnLevel() == 4){
            setDurability(400);
        }
    }

    void setLevelDano(){      
        if(returnLevel() == 1){
            setDano(3);
        }
        else if(returnLevel() == 2){
            setDano(6);
        }
        else if(returnLevel() == 3){
            setDano(9);
        }
        else if(returnLevel() == 4){
            setDano(12);
        }
    }

    public void setLevel(){
        level = Random.Range(1,4);
    }

    public int returnLevel(){
        return level;
    }

    public void setDurability(int quantidade){
        durability = quantidade;
    }

    public int returnDurability(){
        return durability;
    }

    public void setDano(int quantidade){
        dano = quantidade;
    }

    public int returnDano(){
        return dano;
    }

    public void setDurabilityArma1HudArmaTrue(){
        HudArmaTrue.Arma1DurabilidadeAtual = returnDurability();
        //HudArmaTrue.setArma1DurabilidadeMaximo(returnDurability());
    }

    public void setDurabilityArma2HudArmaTrue(){
        //HudArmaTrue.setArma2DurabilidadeAtual(returnDurability());
        //HudArmaTrue.setArma2DurabilidadeMaximo(returnDurability());
    }

}

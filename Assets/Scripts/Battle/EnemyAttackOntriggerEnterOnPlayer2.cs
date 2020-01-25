using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttackOntriggerEnterOnPlayer2 : MonoBehaviour{
    
    public int vidaInimigo;
    public bool entrouInimigoOnTriggerEnter;

    void Awake(){
        setVidaIni(100);
    }

    void FixedUpdate(){
        verificarDano();
    }


    void OnTriggerEnter(Collider collider){
        var select = collider.tag;

        if(select == "personagem"){
            entrouInimigoOnTriggerEnter = true;
            var vida = returnVidaIni();
            setInimigoLifeIntOnEnemy(vida);
        }
    }

    void OnTriggerExit(Collider other) {
        entrouInimigoOnTriggerEnter = false;
    }

    void verificarDano(){
        if(entrouInimigoOnTriggerEnter == true){
            if(personagem.ClicouMouse == true){
                diminuirVidaIni(personagem.returnDanoArma1Personagem());
                var vida = returnVidaIni();
                setInimigoLifeIntOnEnemy(vida);
            }
            
        }
    }

    void setVidaIni(int quantidade){
        vidaInimigo = quantidade;
    }

    void diminuirVidaIni(int quantidade){
        var contador = vidaInimigo - quantidade;
        if( contador < 0 ){
            verificarVidaIni(true);
            setInimigoLifeIntOnEnemy(0);
        }else{
            vidaInimigo -= quantidade;
        }
    }

    int returnVidaIni(){
        return vidaInimigo;
    }

    void verificarVidaIni(bool selecao=false){
        if(returnVidaIni() <= 0 || selecao == true){
            setInimigoLifeIntOnEnemy(0);
            Destroy(this.gameObject);
        }
    }

    public void setInimigoLifeIntOnEnemy(int valor){
        InimigoText.setInimigoLifeInt(valor);
    }
    
}

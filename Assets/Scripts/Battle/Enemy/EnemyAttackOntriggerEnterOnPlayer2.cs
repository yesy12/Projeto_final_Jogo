using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttackOntriggerEnterOnPlayer2 : MonoBehaviour{
    
    public int vidaInimigo;
    public bool entrouInimigoOnTriggerEnter;
    public int time;

    public EnemyDrop enemyDrop;
    public int quantidadeDeXp;

    void Awake(){
        setVidaIni(100);
        getEnemyDropInfo();
    }

    public void getEnemyDropInfo(){
        enemyDrop = this.GetComponent<EnemyDrop>();
        quantidadeDeXp = enemyDrop.quantidadeDeXp;
    }

    void Update(){
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
            // Debug.Log("Entrou if 1");
            if(personagem.ClicouMouse == true){
                time += 1;
                if(time == 10){
                    var danoString = personagem.returnArmaSelecionada();
                    var dano = 0;
                    if(danoString == "arma1"){
                        dano = personagem.returnDanoArma1Personagem();
                    }
                    else if(danoString == "arma2"){
                        dano = personagem.returnDanoArma2Personagem();
                    }
                    diminuirVidaIni(dano);
                    var vida = returnVidaIni();
                    setInimigoLifeIntOnEnemy(vida);
                    time = 0;
                }
            }
        }
    }

    void setVidaIni(int quantidade){
        vidaInimigo = quantidade;
    }

    void diminuirVidaIni(int quantidade){
        var contador = vidaInimigo - quantidade;
        if(contador < 0 ){
            verificarVidaIni(true);
            setInimigoLifeIntOnEnemy(0);
            personagem.setDeuDanoinimigo(true);
        }else{
            vidaInimigo -= quantidade;
            personagem.setDeuDanoinimigo(true);
        }
        personagem.ClicouMouse = false;
    }

    int returnVidaIni(){
        return vidaInimigo;
    }

    void verificarVidaIni(bool selecao=false){
        if(returnVidaIni() <= 0 || selecao == true){
            XpNoPercent.somaXp(quantidadeDeXp);
            setInimigoLifeIntOnEnemy(0);
            Destroy(this.gameObject);
        }
    }

    public void setInimigoLifeIntOnEnemy(int valor){
        InimigoText.setInimigoLifeInt(valor);
    }
    
}

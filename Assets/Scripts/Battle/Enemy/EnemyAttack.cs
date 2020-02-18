using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour{

    public Transform person;
    public float velocityEnemy;
    float zeroF;

    public bool arma1;
    public bool arma2;

    public int dano;
    public string tag;
    public GameObject personagem;

    public int time;
    public int timeFrameQuantidade;
    public int timeFrameAtual;

    // public personagem personagemScript;

    void Start(){
        zeroF = 0f;
        velocityEnemy = 10;
        timeFrameQuantidade = 40;
        // personagemScript = gameObject.GetComponent<personagem>();
        
    }

    // Update is called once per frame
    void Update(){
        getArmaBool_HudArmaTrue();
        if(arma1 == true || arma2 == true){
            followPlayer();
            tirarVida();
        }
    }

    void getArmaBool_HudArmaTrue(){
        arma1 = HudArmaTrue.returnArmaBool("arma1");
        arma2 = HudArmaTrue.returnArmaBool("arma2");
    }

    void followPlayer(){
        transform.LookAt(person.position);
        transform.Translate(zeroF,zeroF, velocityEnemy * Time.deltaTime);
    }

    void tirarVida(){
        if(tag == "personagem"){
            timeFrameAtual += 1;
            if(timeFrameAtual == timeFrameQuantidade){
                LifeNoPercent.tirarVida(dano);
                timeFrameAtual = 0;
            }
        }
    }

    void OnTriggerEnter(Collider other){
        tag = other.tag;
    }

    void OnTriggerExit(Collider other){
        tag = "";
    }
}

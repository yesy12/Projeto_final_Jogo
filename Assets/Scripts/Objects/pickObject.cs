﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickObject : MonoBehaviour{

    public static bool buttonEclick;
    public ItemArray itemArray;

    public GameObject objeto;
    public string select;

    public ArmorSetDurability ObjetoArmorSetDurability;

    public bool entrouNaArma;

    public bool arma1;
    public bool arma2;

    void FixedUpdate(){
        removerItem();
    }

    void OnTriggerEnter(Collider other) {
        select = other.tag;

        arma1 = HudArmaTrue.returnArmaBool("arma1");
        arma2 = HudArmaTrue.returnArmaBool("arma2");

        if(select == "espada" || select == "machado"){
            objeto = other.gameObject;

            if(arma1 == false){// || arma2 == false
                setEntrouNaArma(true);
                getComponent();
                setMessagePanelInfo(select);
                HudArmaTrue.returnArmaBool("arma1");
            }
            else{
                
            }

        }
    }

    void removerItem(){
        if(personagem.getApertouE() == true && returnEntrouArma() == true){
            
            //AmorSetDurability
            var durabilidade = ObjetoArmorSetDurability.returnDurability();
            var dano = ObjetoArmorSetDurability.returnDano();
            var level = ObjetoArmorSetDurability.returnLevel();

            //Hud
            HudArmaTrue.setArmaString(select);
            HudArmaTrue.setArmaSwitchBool(true);
            HudArmaTrue.setArmaDurabilidade_Arma1_Arma2(durabilidade);
            HudArmaTrue.setArmaLevel_Arma1_Arma2(level);
            HudArmaTrue.setArmaDano_Arma1_Arma2(dano);
            HudArmaTrue.setDano(dano); 

            //Personagem
            personagem.setApertouE(false);

            //Geral
            MessagePanel.SetItensTrueOrFalse(false);
            ItemArray.RemoverItem(objeto);
            Destroy(objeto);
            setEntrouNaArma(false);
        }
    }

    void OnTriggerExit(Collider other) {
        MessagePanel.SetItensTrueOrFalse(false);
    }

    void getComponent(){
        itemArray = objeto.GetComponent<ItemArray>();
        ObjetoArmorSetDurability = objeto.GetComponent<ArmorSetDurability>();
    }

    void setMessagePanelInfo(string select){
        MessagePanel.SetItensTrueOrFalse(true);
        MessagePanel.setDescricaoValor(select);

        var durabilidade = "Durabilidade ";
        durabilidade += ObjetoArmorSetDurability.returnDurability();
        MessagePanel.setDurabilidadeValor(durabilidade);

        var nivel = "Nivel ";
        nivel += ObjetoArmorSetDurability.returnLevel();
        MessagePanel.setNivelValor(nivel);

        var dano = "Dano ";
        dano += ObjetoArmorSetDurability.returnDano();
        MessagePanel.setDanoValor(dano);
    }

    public void setEntrouNaArma(bool selecao){
        entrouNaArma = selecao;
    }

    public bool returnEntrouArma(){
        return entrouNaArma;
    }


}
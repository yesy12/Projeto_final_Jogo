using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickObject : MonoBehaviour{

    public static bool buttonEclick;
    public ItemArray itemArray;

    public GameObject objeto;
    public string select;

    public ArmorSetDurability ObjetoArmorSetDurability;

    void FixedUpdate(){
        removerItem();
    }

    void OnTriggerEnter(Collider other) {
        select = other.tag;

        if(select == "espada" || select == "machado"){
            objeto = other.gameObject;

            getComponent();
            setMessagePanelInfo(select);
        }
    }

    void removerItem(){
        if(personagem.getApertouE() == true){
            
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

}
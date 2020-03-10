using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PocoesPanel : MonoBehaviour{

    public GameObject PocoesPanelGameObject;
    public static bool PocoesPanelBool;

    public Text descricaoPocoesPanel;
    public static string descricaoPocoesPanelString;

    public Text quantidadePocoesPanel;
    public static string quantidadePocoesString;


    void Start(){
        Close_Open_PocoesPanel(false);
        // // setDescricaoPocoesPanelOnHud("Pocoes de Vida");
        // setQuantidadePocoesPanel("Quantidade 10");
    }


    void Update(){
        var panelClose_Open = returnClose_Open_Pocoes_Panel();
        if(panelClose_Open == true){
            Close_Open_PocoesPanel(panelClose_Open);

            var descricao = returnDescricaoPanel();
            setDescricaoPocoesPanelOnHud(descricao);

            var quantidade =  returnQuantidadePanel();
            setQuantidadePocoesPanelOnHud(quantidade);
        }
        else if(panelClose_Open == false){
            Close_Open_PocoesPanel(panelClose_Open);
        }
    }

    public static void setClose_Open_Pocoes_Panel(bool selecao){
        PocoesPanelBool = selecao;
    }

    public static bool returnClose_Open_Pocoes_Panel(){
        return PocoesPanelBool;
    }

    void Close_Open_PocoesPanel(bool selecao){
        PocoesPanelGameObject.SetActive(selecao);
    }

    void setDescricaoPocoesPanelOnHud(string selecao){
        descricaoPocoesPanel.text = selecao;
    }

    public static void setDescricaoPanel(string texto){
        descricaoPocoesPanelString = texto;
    }

    public static string returnDescricaoPanel(){
        return descricaoPocoesPanelString;
    }

    void setQuantidadePocoesPanelOnHud(string selecao){
        quantidadePocoesPanel.text = selecao;
    }

    public static void setQuantidadePanel(string texto){
        quantidadePocoesString = texto;
    }

    public static string returnQuantidadePanel(){
        return quantidadePocoesString;
    }

}

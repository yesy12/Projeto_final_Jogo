using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MessagePanel : MonoBehaviour{

    public GameObject messagePanelItem;
    public static bool messageItemTrue;


    public GameObject descricaoPanelItem;
    public Text descricaoPanelText;
    public static string descricao;
    public static bool descricaoItemTrue;


    public GameObject durabilidadePanelItem;
    public Text durabilidadePanelText;
    public static string durabilidade;
    public static bool durabilidadeItemTrue;



    public GameObject nivelPanelItem;
    public Text nivelPanelText;
    public static string nivel;
    public static bool nivelItemTrue;   


    public GameObject dano_curaPanelItem;
    public Text dano_curaPanelText;
    public static string dano_cura;
    public static bool dano_curaItemTrue;   


    public GameObject PanelTroca_de_Itens;
    public static bool TrocaItensTrue;


    public GameObject PanelConfirmacaoItem;
    public static bool PanelConfirmacaoItemTrue;

    public int tempoSeg;
    public int timeFrameQuantidade;

    public int timeFrameAtual;

    void Awake(){
        timeFrameQuantidade = 40;
        SetItensTrueOrFalse(false);
        // Open_ClosePanelTroca_de_Itens(true);
        
    }

    void Update(){
        setTempo();
    }

    void FixedUpdate(){
        ItensTrues();
        ValoresNoHud();
    }

    public void setTempo(){
        timeFrameAtual += 1;

        if(timeFrameAtual == timeFrameQuantidade){
            tempoSeg += 1;
            timeFrameQuantidade = 0;
        }

    }

    public static void SetItensTrueOrFalse(bool selecao){
        setMessageItemTrue(selecao);
        setDescricaoTrue(selecao);
        setDurabilidadeTrue(selecao);
        setNivelTrue(selecao);
        setDanoTrue(selecao);
        // setTroca_de_ItensTrue(selecao);
    }

    public void ItensTrues(){
        verificarMessageTrue();
        verificarDescricaoItemTrue();
        verificarDurabilidadeItemTrue();
        verificarNivelItemTrue();
        verificarDanoItemTrue();
        verificarTrocaItensTrue();
    }

    public void ValoresNoHud(){
        setDescricaoValorHud(returnDescricaoValor());
        setDurabilidadeValorHud(returnDurabilidadeValor());
        setNivelValorHud(returnNivelValor());
        setDanoValorHud(returnDanoValor());
    }

    /*
        Verificação se pode abrir
    */

    public void verificarMessageTrue(){
        var selecao = returnMessageItemTrue();
        Open_Close_MessagePanel(selecao);
    }

    public void verificarDescricaoItemTrue(){
        var selecao = returnDescricaoTrue();
        Open_CloseDescricaoPanel(selecao);
    }
        
    public void verificarDurabilidadeItemTrue(){
        var selecao = returnDurabilidadeTrue();
        Open_CloseDurabilidadePanel(selecao);
    }

    public void verificarNivelItemTrue(){
        var selecao = returnNivelTrue();
        Open_CloseNivelPanel(selecao);
    }

    public void verificarDanoItemTrue(){
        var selecao = returnDanoTrue();
        Open_CloseDanoPanel(selecao);
    }

    public void verificarTrocaItensTrue(){
        var selecao = returnTrocaItensTrue();
        Open_ClosePanelTroca_de_Itens(selecao);
    }

    public void verificarConfirmacaoItensTrue(){
        var selecao = returnTrocaItensTrue();
        Open_ClosePanelTroca_de_Itens(selecao);
    }
    /*
        Abre na tela as opções com descrições
    */

    public void Open_Close_MessagePanel(bool selecao){
        messagePanelItem.SetActive(selecao);
    }

    public void Open_CloseDescricaoPanel(bool selecao){
        descricaoPanelItem.SetActive(selecao);
    }

    public void Open_CloseDurabilidadePanel(bool selecao){
        durabilidadePanelItem.SetActive(selecao);
    }

    public void Open_CloseNivelPanel(bool selecao){
        nivelPanelItem.SetActive(true);
    }

    public void Open_CloseDanoPanel(bool selecao){
        dano_curaPanelItem.SetActive(selecao);
    }

    public void Open_ClosePanelTroca_de_Itens(bool selecao){
        var tempo = 
        PanelTroca_de_Itens.SetActive(selecao);
    }

    
    public void Open_ClosePanelConfirmacaoItem(bool selecao){
        PanelConfirmacaoItem.SetActive(selecao);
    }


    public static void setMessageItemTrue(bool selecao){
        messageItemTrue = selecao;
    }

    public static void setDescricaoTrue(bool selecao){
        descricaoItemTrue = selecao;
    }

    public static void setDurabilidadeTrue(bool selecao){
        durabilidadeItemTrue = selecao;
    }

    public static void setNivelTrue(bool selecao){
        nivelItemTrue = selecao;
    }

    public static void setDanoTrue(bool selecao){
        dano_curaItemTrue = selecao;
    }


    public static void setTroca_de_ItensTrue(bool selecao){
        TrocaItensTrue = selecao;
    }


    /*
        Itens para valor statico
        Para ser usado em outros scripts
    */

    // setValor Static 


    public static void setDescricaoValor(string texto){
        descricao = texto;
    }

    public static void setDurabilidadeValor(string texto){
        durabilidade = texto;
    }

    public static void setNivelValor(string texto){
        nivel = texto;
    }

    public static void setDanoValor(string texto){
        dano_cura = texto;
    }


    // returnValor Static

    public static string returnDurabilidadeValor(){
        return durabilidade;
    }

    public static string returnDescricaoValor(){
        return descricao;
    }

    public static string returnNivelValor(){
        return nivel;
    }

    public static string returnDanoValor(){
        return dano_cura;
    }



    //SetValorHud No Static

    public void setDescricaoValorHud(string texto){
        descricaoPanelText.text = texto;
    }

    public void setDurabilidadeValorHud(string texto){
        durabilidadePanelText.text = texto;
    }

    public void setNivelValorHud(string texto){
        nivelPanelText.text = texto;
    }

    public void setDanoValorHud(string texto){
        dano_curaPanelText.text = texto;
    }


    //ReturnMessageItemTrue

    public static bool returnMessageItemTrue(){
        return messageItemTrue;
    }

    public bool returnDescricaoTrue(){
        return descricaoItemTrue;
    }

    public bool returnDurabilidadeTrue(){
        return durabilidadePanelText;
    }

    public bool returnNivelTrue(){
        return nivelItemTrue;
    }

    public bool returnDanoTrue(){
        return dano_curaItemTrue;
    }

    public bool returnTrocaItensTrue(){
        return TrocaItensTrue;
    }

}
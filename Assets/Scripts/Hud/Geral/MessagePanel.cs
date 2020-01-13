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
    public Text dano_curaPanelItem;
    public static string dano_cura;
    public static bool dano_curaItemTrue;   


    void Awake(){
        SetItensTrueOrFalse(false);
    }

    void FixedUpdate(){
        ItensTrues();
        ValoresNoHud();
    }

    public static void SetItensTrueOrFalse(bool selecao){
        setMessageItemTrue(selecao);
        setDescricaoTrue(selecao);
        setDurabilidadeTrue(selecao);
        setNivelTrue(selecao);
        setDanoTrue(selecao);
    }

    public void ItensTrues(){
        verificarMessageTrue();
        verificarDescricaoItemTrue();
        verificarDurabilidadeItemTrue();
        verificarNivelItemTrue();
        verificarDanoItemTrue();
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
        if(returnMessageItemTrue() == true){
            OpenMessagePanel();
        }
        else{
            CloseMessagePanel();
        }
    }

    public void verificarDescricaoItemTrue(){
        if(returnDescricaoTrue() == true){
            OpenDescricaoPanel();
        }
        else{
            CloseDescricaoPanel();
        }
    }
        
    public void verificarDurabilidadeItemTrue(){
        if(returnDurabilidadeTrue() == true){
            OpenDurabilidadePanel();
        }
        else{
            CloseDurabilidadePanel();
        }
    }

    public void verificarNivelItemTrue(){
        if(returnMessageItemTrue() == true){
            OpenNivelPanel();
        }
        else{
            CloseNivelPanel();
        }
    }

    public void verificarDanoItemTrue(){
        if(returnDanoTrue() == true){
            OpenDanoPanel();
        }
        else{
            CloseDanoPanel();
        }
    }

    /*
        Abre na tela as opções com descrições
    */

    public void OpenMessagePanel(){
        messagePanelItem.SetActive(true);
    }

    public void OpenDescricaoPanel(){
        descricaoPanelItem.SetActive(true);
    }

    public void OpenDurabilidadePanel(){
        durabilidadePanelItem.SetActive(true);
    }

    public void OpenNivelPanel(){
        nivelPanelItem.SetActive(true);
    }

    public void OpenDanoPanel(){
        dano_curaPanelItem.SetActive(true);
    }


    /*
        Fecha na tela as opções com descrições
    */


    public void CloseMessagePanel(){
        messagePanelItem.SetActive(false);
    }

    public void CloseDescricaoPanel(){
        descricaoPanelItem.SetActive(false);
    }

    public void CloseDurabilidadePanel(){
        durabilidadePanelItem.SetActive(false);
    }

    public void CloseNivelPanel(){
        nivelPanelItem.SetActive(false);
    }       

    public void CloseDanoPanel(){
        dano_curaPanelItem.SetActive(false);
    }       

    /*

     Se esta aberto ou não
    */


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
        dano_curaPanelItem.text = texto;
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

}
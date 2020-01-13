using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HudArmaTrue : MonoBehaviour{

    // Bool
    public static bool SwitchArmaBool;
    public static bool Arma1Bool;
    public static bool Arma2Bool;

    // Arma1 
    public GameObject Arma1Espada;
    public GameObject Arma1Machado;

    // Icones
    public GameObject Arma2Espada;
    public GameObject Arma2Machado;

    //Durabilidades
    public GameObject Arma1Durabilidade;
    public GameObject Arma2Durabilidade;


    // Durabilidade Atual
    public static int Arma1DurabilidadeAtual;
    public static int Arma2DurabilidadeAtual;

    // Durabilidade Maxima
    public static int Arma1DurabilidadeMaxima;
    public static int Arma2DurabilidadeMaxima;

    //ArmaTextDurabilidade
    public Text Arma1TextDurabilidade;
    public Text Arma2TextDurabilidade;

    //dano
    public static int dano;


    public static string ArmaString;

    void Awake(){
        setArmaSwitchBool(false);
    }


    void FixedUpdate(){
        if(returnArmaSwitchBool() == true){
            selecaoArma();
            setArmaSwitchBool(false);
        }
    }

    void selecaoArma(){
        if(returnArma1Bool() == false){
            Arma1Ativa();
            Arma1DurabilidadeAtiva();
            setArma1Bool(true);
            setArma1DurabilidadeText();
            personagem.setDanoArma1Personagem(returnDano());        
        }
        else if(returnArma2Bool() == false){
            Arma2Ativa();
            Arma2DurabilidadeAtiva();
            setArma2Bool(true);
            setArma2DurabilidadeText();
            personagem.setDanoArma2Personagem(returnDano());   
        }
    }


    //Ativa
    void Arma1Ativa(){
        if(returnArmaString() == "espada"){
            Arma1EspadaAtiva();
            InventarioHud.setArma1EspadaAtiva_DesativaBool(true);
        }
        else if(returnArmaString() == "machado"){
            Arma1MachadoAtiva();
            InventarioHud.setArma1MachadoAtiva_DesativaBool(true);
        }    
    }

    void Arma2Ativa(){
        if(returnArmaString() == "espada"){
            Arma2EspadaAtiva();
            InventarioHud.setArma2EspadaAtiva_DesativaBool(true);    
        }
        else if(returnArmaString() == "machado"){
            Arma2MachadoAtiva();
            InventarioHud.setArma2MachadoAtiva_DesativaBool(true);
        }   
    }

    void Arma1EspadaAtiva(){
        Arma1Espada.SetActive(true);
    }
    
    void Arma1MachadoAtiva(){
        Arma1Machado.SetActive(true);
    }

    void Arma2EspadaAtiva(){
        Arma2Espada.SetActive(true);
    }
    
    void Arma2MachadoAtiva(){
        Arma2Machado.SetActive(true);
    }

    public void Arma1DurabilidadeAtiva(){
        Arma1Durabilidade.SetActive(true);
    }    
    public void Arma2DurabilidadeAtiva(){
        Arma2Durabilidade.SetActive(true);
    }


    //Desativa












    //Sets
    public static void setArmaString(string texto){
        ArmaString = texto;
    }

    public static void setArmaSwitchBool(bool selecao){
        SwitchArmaBool = selecao;
    }

    public static void setArma2Bool(bool selecao){
        Arma2Bool = selecao;
    }

    public static void setArma1Bool(bool selecao){
        Arma1Bool = selecao;
    }

    public static void setArma1DurabilidadeAtual(int quantidade){
        Arma1DurabilidadeAtual = quantidade;
    }

    public static void setArma2DurabilidadeAtual(int quantidade){
        Arma2DurabilidadeAtual = quantidade;
    }

    public static void setArma1DurabilidadeMaxima(int quantidade){
        Arma1DurabilidadeMaxima = quantidade;
    }

    public static void setArma2DurabilidadeMaxima(int quantidade){
        Arma2DurabilidadeMaxima = quantidade;
    }

    public static void setArma1Durabilidade_Atual_Maxima(int quantidade){
        setArma1DurabilidadeAtual(quantidade);
        setArma1DurabilidadeMaxima(quantidade);
    }

    public static void setArma2Durabilidade_Atual_Maxima(int quantidade){
        setArma2DurabilidadeAtual(quantidade);
        setArma2DurabilidadeMaxima(quantidade);
    }

    public static void setArmaDurabilidade_Arma1_Arma2(int quantidade){
        if(returnArma1Bool() == false){
            Debug.Log(quantidade);
            setArma1Durabilidade_Atual_Maxima(quantidade);
        }
        else if(returnArma2Bool() == false){
            Debug.Log(quantidade);
            setArma2Durabilidade_Atual_Maxima(quantidade);
        }
    }

    public void setArma1DurabilidadeText(){
        Arma1TextDurabilidade.text = returnArma1DurabilidadeAtual() + "/" + returnArma1DurabilidadeMaxima();
    }

    public void setArma2DurabilidadeText(){
        Arma2TextDurabilidade.text = returnArma2DurabilidadeAtual() + "/" + returnArma2DurabilidadeMaxima();
    }

    public static void setDano(int quantidade){
        dano = quantidade;
    }


    //Returns
    public static string returnArmaString(){
        return ArmaString;
    }

    public static bool returnArmaSwitchBool(){
        return SwitchArmaBool;
    }

    public static bool returnArma1Bool(){
        return Arma1Bool;
    }
    
    public static bool returnArma2Bool(){
        return Arma2Bool;
    }

    public static int returnArma1DurabilidadeAtual(){
        return Arma1DurabilidadeAtual;
    }

    public static int returnArma2DurabilidadeAtual(){
        return Arma2DurabilidadeAtual;
    }

    public static int returnArma1DurabilidadeMaxima(){
        return Arma1DurabilidadeMaxima;
    }

    public static int returnArma2DurabilidadeMaxima(){
        return Arma2DurabilidadeMaxima;
    }

    public static int returnDano(){
        return dano;
    }

}
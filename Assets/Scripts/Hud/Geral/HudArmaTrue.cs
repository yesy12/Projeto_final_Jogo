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

    // Nivel
    public static int Arma1Nivel;
    public static int Arma2Nivel;

    //Dano 
    public static int Arma1Dano;
    public static int Arma2Dano;

    public static string ArmaString;

    public XpNoPercent xpNoPercent;

    void Awake(){
        setArmaSwitchBool(false);
        xpNoPercent = this.GetComponent<XpNoPercent>();
    }

    void Update(){
        var texto = "";
        if(returnArmaBool("arma1") == true){
            texto = "arma1";
        }
        if(returnArmaBool("arma2") == true){
            texto = "arma2";
        }
        if(texto != ""){
            setArmaDurabilidadeText(texto);
        }
        destoiArma();
    }

    void FixedUpdate(){
        if(returnArmaSwitchBool() == true){
            selecaoArma();
            setArmaSwitchBool(false);
        }
    }

    void selecaoArma(){
        var dano = returnDano();
        var danoMaisXpNoPercent = xpNoPercent.danoMais;
        var texto = "";
        var danoSomado = dano + danoMaisXpNoPercent;

        if(returnArmaBool("arma1") == false){
            texto = "arma1";
        }
        else if(returnArmaBool("arma2") == false){
            texto = "arma2";
        }
        if(texto != ""){
            ArmaAtiva_Desativa(texto,true);
            ArmaDurabilidadeAtiva_Desativa(texto,true);
            setArmaBool(texto,true);
            setArmaDurabilidadeText(texto);
            personagem.setDanoArma1Personagem(texto,danoSomado);        
        
        }

    }


    void destoiArma(){
        var durabilidade1 = returnArmaDurabilidadeAtual("arma1");
        var durabilidade2 = returnArmaDurabilidadeAtual("arma2");

        print(durabilidade1);
        if(durabilidade1 <= 0){
            ArmaAtiva_Desativa("arma1",false);
            ArmaDurabilidadeAtiva_Desativa("arma1",false);
        }

    }

    //Ativa
    void ArmaAtiva_Desativa(string selecaoString,bool selecaoBool){
        if(selecaoString == "arma1"){
            var arma = returnArmaString();
            Arma1Ativa_Desativa(arma,selecaoBool);
            InventarioHud.setArma1EspadaAtiva_DesativaBool(true);
        }
        else if(selecaoString == "arma2"){
            var arma = returnArmaString();
            Arma2Ativa_Desativa(arma,selecaoBool);
            InventarioHud.setArma2EspadaAtiva_DesativaBool(true);
        }
    }

    void Arma1Ativa_Desativa(string selecaoString,bool selecaoBool){
        if(selecaoString == "espada"){
            Arma1Espada.SetActive(selecaoBool);
        }
        else if(selecaoString == "machado"){
            Arma1Machado.SetActive(selecaoBool);
        }
    }
    
    void Arma2Ativa_Desativa(string selecaoString,bool selecaoBool){
        if(selecaoString == "espada"){
            Arma2Espada.SetActive(selecaoBool);
        }
        else if(selecaoString == "machado"){
            Arma2Machado.SetActive(selecaoBool);
        }
    }

    public void ArmaDurabilidadeAtiva_Desativa(string selecaoString,bool selecaoBool){
        if(selecaoString == "arma1"){
            Arma1Durabilidade.SetActive(selecaoBool);
        }
        else if(selecaoString == "arma2"){
            Arma2Durabilidade.SetActive(selecaoBool);
        }
    }    


    //Sets
    public static void setArmaString(string texto){
        ArmaString = texto;
    }

    public static void setArmaSwitchBool(bool selecao){
        SwitchArmaBool = selecao;
    }

    public static void setArmaBool(string selecaoString,bool selecaoBool){
        if(selecaoString == "arma1"){
            Arma1Bool = selecaoBool;
        }
        else if(selecaoString == "arma2"){
            Arma2Bool = selecaoBool;
        }
       
    }

    public static void setArmaDurabilidadeAtual(string selecaoString,int quantidade){
        if(selecaoString == "arma1"){
            Arma1DurabilidadeAtual = quantidade;
        }
        else if(selecaoString == "arma2"){
            Arma2DurabilidadeAtual = quantidade;
        }
        
    }

    public static void setDiminuirArma1DurabilidadeAtual(string selecaoString,int quantidade){
        if(selecaoString == "arma1"){
            Arma1DurabilidadeAtual -= quantidade;
        }
        else if(selecaoString == "arma2"){
            Arma2DurabilidadeAtual -= quantidade;
        }
    }

    public static void setArmaDurabilidadeMaxima(string selecaoString,int quantidade){
        if(selecaoString == "arma1"){
            Arma1DurabilidadeMaxima = quantidade;
        }
        else if(selecaoString == "arma2"){
            Arma2DurabilidadeMaxima = quantidade;
        }
    }

    public static void setArmaNivel(string selecaoString,int quantidade){
        if(selecaoString == "arma1"){
            Arma1Nivel = quantidade;
        }
        else if(selecaoString == "arma2"){
            Arma2Nivel = quantidade;
        }
    }

    public static void setArmaDano(string selecaoString,int quantidade){
        if(selecaoString == "arma1"){
            Arma1Dano = quantidade;
        }
        else if(selecaoString == "arma2"){
            Arma2Dano = quantidade;
        }

       
    }

    public static int returnArmaDano(string selecaoString){
        var selecao = 0;
        if(selecaoString == "arma1"){
            selecao = Arma1Dano;
        }
        else if(selecaoString == "arma2"){
            selecao =  Arma2Dano;
        }
        return selecao;
    }

    public static string returnArmaDanoString(string selecaoString){
        var selecao = "";

        if(selecaoString == "arma1"){
            selecao = Arma1Dano.ToString();
        }
        else if(selecaoString == "arma2"){
            selecao = Arma2Dano.ToString();
        }
        return selecao;
    }

    public static void setArmaDurabilidade_Atual_Maxima(string selecaoString,int quantidade){
        var texto = selecaoString;
        setArmaDurabilidadeAtual(texto,quantidade);
        setArmaDurabilidadeMaxima(texto,quantidade);          
    }

    public static void setArmaDurabilidade_Arma1_Arma2(int quantidade){
        var texto = "";
        if(returnArmaBool("arma1") == false){
            texto = "arma1";
        }
        else if(returnArmaBool("arma2") == false){
            texto = "arma2";
        }
        if(texto != ""){    
            setArmaDurabilidade_Atual_Maxima(texto,quantidade);
        }
    }

    public static void setArmaLevel_Arma1_Arma2(int quantidade){
        if(returnArmaBool("arma1") == false){
            setArmaNivel("arma1",quantidade);
        }
        else if(returnArmaBool("arma2") == false){
            setArmaNivel("arma2",quantidade);
        }
    }

    public static void setArmaDano_Arma1_Arma2(int quantidade){
        if(returnArmaBool("arma1") == false){
            setArmaDano("arma1",quantidade);
        }
        else if(returnArmaBool("arma2") == false){
            setArmaDano("arma2",quantidade);
        }
    }

    public void setArmaDurabilidadeText(string selecaoString){
        var texto =  selecaoString;
        if(texto == "arma1"){
            Arma1TextDurabilidade.text = returnArmaDurabilidadeAtual(texto) + "/" + returnArmaDurabilidadeMaxima(texto);
        }
        else if(texto == "arma2"){
            Arma2TextDurabilidade.text = returnArmaDurabilidadeAtual(texto) + "/" + returnArmaDurabilidadeMaxima(texto);
        }
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

    public static bool returnArmaBool(string selecaoString){
        var boolSelecao = false;
        if(selecaoString == "arma1"){
            boolSelecao = Arma1Bool;
        }
        else if(selecaoString == "arma2"){
            boolSelecao = Arma2Bool;
        }
        return boolSelecao;
    }

    public static int returnArmaDurabilidadeAtual(string selecaoString){
        var durabilidadeSelecao = 0;
        if(selecaoString == "arma1"){
            durabilidadeSelecao = Arma1DurabilidadeAtual;
        }
        else if(selecaoString == "arma2"){
            durabilidadeSelecao = Arma2DurabilidadeAtual;
        }
        return durabilidadeSelecao;
    }

    public static int returnArmaDurabilidadeMaxima(string selecaoString){
        var durabilidadeSelecao = 0;
        if(selecaoString == "arma1"){
            durabilidadeSelecao = Arma1DurabilidadeMaxima;
        }
        else if(selecaoString == "arma2"){
            durabilidadeSelecao = Arma2DurabilidadeMaxima;
        }
        return durabilidadeSelecao;
    }
    public static int returnDano(){
        return dano;
    }

}
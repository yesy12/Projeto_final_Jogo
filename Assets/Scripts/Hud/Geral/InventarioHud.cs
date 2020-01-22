using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventarioHud : MonoBehaviour{

    // Hud HudBar

    //Life
    [SerializeField] Text quantidadePocoesLifeText;
    public static int quantidadePocoesLifeInt;

    //Stamina
    [SerializeField] Text quantidadePocoesStaminaText;
    public static int quantidadePocoesStaminaInt;

    //Xp
    [SerializeField] Text quantidadePocoesXpText;
    public static int quantidadePocoesXpInt;


    //Bau
    [SerializeField] Text quantidadeBauText;
    public static int quantidadeBauInt;

    // Hud Inventário

    //Armas
    public GameObject Arma1Espada;
    public static bool Arma1EspadaBool;
    public GameObject Arma1Machado;
    public static bool Arma1MachadoBool;
    public GameObject DurabilidadeArma1;  

    public GameObject Arma2Espada;
    public static bool Arma2EspadaBool;
    public GameObject Arma2Machado; 
    public static bool Arma2MachadoBool;          
    public GameObject DurabilidadeArma2;    


    public GameObject Inventario;
    public GameObject DescricaoInventario;

    //Bool
    public static bool InventarioBool;
    public static bool DescricaoInventarioBool;

    [SerializeField] Text quantidadePocoesLifeTextInventario;
    public static int quantidadePocoesLifeIntInventario;

    //Stamina
    [SerializeField] Text quantidadePocoesStaminaTextInventario;
    public static int quantidadePocoesStaminaIntInventario;

    //Xp
    [SerializeField] Text quantidadePocoesXpTextInventario;
    public static int quantidadePocoesXpIntInventario;

    //Bau
    [SerializeField] Text quantidadeBauTextInventario;
    public static int quantidadeBauIntInventario;

    //Panel Descricao Inventario
    //Descricao
    public GameObject descricaoRecursoPanelItem;
    public Text descricaoRecursoPanelText;
    public static string descricaoRecursoPanelString;
    public static bool descricaoRecursoPanelItemBool;

    //Durabilidade
    public GameObject durabilidadeRecursoPanelItem;
    public Text durabilidadeRecursoPanelText;
    public static string durabilidadeRecursoPanelString;
    public static bool durabilidadeRecursoPanelItemBool;

    //Nivel
    public GameObject nivelRecursoPanelItem;
    public Text nivelRecursoPanelText;
    public static string nivelRecursoPanelString;
    public static bool nivelRecursoPanelItemBool;

    //Dano
    public GameObject danoRecursoPanelItem;
    public Text danoRecursoPanelText;
    public static string danoRecursoPanelString;
    public static bool danoRecursoPanelItemBool;
    

    void Awake(){

        //HudBar
        setQuantidadePocoesLife(5);
        setQuantidadePocoesStamina(5);
        setQuantidadePocoesXp(2);
        setQuantidadeBau(2);



        //Inventario
        setInventarioAtiva_DesativaBool(false);
        setDescricaoInventarioBoolAtiva_DesativaBool(false);
        
    }


    void FixedUpdate(){
        //Life
        var life = returnQuantidadePocoesLife();
        setLifeQuantidadeHud(life);
        setLifeQuantidadeInventario(life);

        //Stamina
        var stamina = returnQuantidadePocoesStamina();
        setStaminaQuantidadeHud(stamina);
        setStaminaQuantidadeInventario(stamina);

        //Xp
        var xp = returnQuantidadePocoesXp();
        setXpQuantidadeHud(xp);
        setXpQuantidadeInventario(xp);

        //Bau
        var bau = returnQuantidadeBau();
        setBauQuantidadeHud(bau);
        setBauQuantidadeInventario(bau);

        InventarioAtiva_Desativa();
        DescricaoInventarioAtiva_Desativa();
        
        setArma1EspadaAtiva_Desativa();
        setArma1MachadoAtiva_Desativa();

        setArma2EspadaAtiva_Desativa();
        setArma2MachadoAtiva_Desativa();

        var descricao = returnDescricaoRecursoPanelText();
        setDescricaoRecursoPanelTextHud(descricao);

        var durabilidade = returnDurabilidadeRecursoPanelText();
        setDurabilidadeRecursoPanelTextHud(durabilidade);

        var nivel = returnNivelRecursoPanelText();
        setNivelRecursoPanelTextHud(nivel);

        var dano = returnDanoRecursoPanelText();
        setDanoRecursoPanelTextHud(dano);

    }

    //HudBar
    //set Quantidade Hud
    public void setLifeQuantidadeHud(string texto){
        quantidadePocoesLifeText.text = texto;
    }    

    public void setStaminaQuantidadeHud(string texto){
        quantidadePocoesStaminaText.text = texto;
    }

    public void setXpQuantidadeHud(string texto){
        quantidadePocoesXpText.text = texto;
    }

    public void setBauQuantidadeHud(string texto){
        quantidadeBauText.text = texto;
    }



    //Quantidade Aleatoria
    public static void setQuantidadePocoesLife(int quantidade){
        quantidadePocoesLifeInt = quantidade;
    }

    public static void setQuantidadePocoesStamina(int quantidade){
        quantidadePocoesStaminaInt = quantidade;
    }

    public static void setQuantidadePocoesXp(int quantidade){
        quantidadePocoesXpInt = quantidade;
    }

    public static void setQuantidadeBau(int quantidade){
        quantidadeBauInt = quantidade;
    }


    //Retorno Inteiro
    public static int returnQuantidadePocoesLifeInt(){
        return quantidadePocoesLifeInt;
    }

    public static int returnQuantidadePocoesStaminaInt(){
        return quantidadePocoesStaminaInt;
    }

    public static int returnQuantidadePocoesXpInt(){
        return quantidadePocoesXpInt;
    }   

    public static int returnQuantidadeBauInt(){
        return quantidadeBauInt;
    }   



    //Retorno String 
    public static string returnQuantidadePocoesLife(){
        var temp = returnQuantidadePocoesLifeInt();
        var temp2 = returnIntParaString(temp);
        return temp2;
    }

    public static string returnQuantidadePocoesStamina(){
        var temp = returnQuantidadePocoesStaminaInt();
        var temp2 = returnIntParaString(temp);
        return temp2;
    }

    public static string returnQuantidadePocoesXp(){
        var temp = returnQuantidadePocoesXpInt();
        var temp2 = returnIntParaString(temp);
        return temp2;
    } 

    public static string returnQuantidadeBau(){
        var temp = returnQuantidadeBauInt();
        var temp2 = returnIntParaString(temp);
        return temp2;
    } 


    //Somar Pocoes e Bau
    public static void somarPocoesLife(int quantidade){
        quantidadePocoesLifeInt += quantidade;
    }

    public static void somarPocoesStamina(int quantidade){
        quantidadePocoesStaminaInt += quantidade;
    }

    public static void somarPocoesXp(int quantidade){
        quantidadePocoesXpInt += quantidade;
    }    

    public static void somarBau(int quantidade){
        quantidadeBauInt += quantidade;
    }    


    //Diminuir Pocoes e Bau
    public static void diminuirPocoesLife(int quantidade){
        quantidadePocoesLifeInt -= quantidade;
    }

    public static void diminuirPocoesStamina(int quantidade){
        quantidadePocoesStaminaInt -= quantidade;
    }

    public static void diminuirPocoesXp(int quantidade){
        quantidadePocoesXpInt -= quantidade;
    }    

    public static void diminuirBau(int quantidade){
        quantidadeBauInt -= quantidade;
    }   

    public static string returnIntParaString(int valor){
        return valor.ToString();
    }

    //Inventário

    public void InventarioAtiva_Desativa(){
        if(returnInventarioAtiva_DesativaBool() == true){
            Inventario.SetActive(true);
        }else{
            Inventario.SetActive(false);
        }

    }

    public static void setInventarioAtiva_DesativaBool(bool selecao){
        InventarioBool = selecao;
    }

    public static bool returnInventarioAtiva_DesativaBool(){
        return InventarioBool;
    }

    public void DescricaoInventarioAtiva_Desativa(){
        if(returnDescricaoInventarioBoolAtiva_DesativaBool() == true){
            DescricaoInventario.SetActive(true);
        }else{
            DescricaoInventario.SetActive(false);
        }
    }

    public static void setDescricaoInventarioBoolAtiva_DesativaBool(bool selecao){
        DescricaoInventarioBool = selecao;
    }

    public static bool returnDescricaoInventarioBoolAtiva_DesativaBool(){
        return DescricaoInventarioBool;
    }

    // Arma1 Espada 
    public static void setArma1EspadaAtiva_DesativaBool(bool selecao){
        Arma1EspadaBool = selecao;
    }

    public static bool returnArma1EspadaAtiva_DesativaBool(){
        return Arma1EspadaBool;
    }

    public void setArma1EspadaAtiva_Desativa(){
        if(returnArma1EspadaAtiva_DesativaBool() == true){
            Arma1Espada.SetActive(true);
        }else{
            Arma1Espada.SetActive(false);
        }
    }

    // Arma1 Machado
    public static void setArma1MachadoAtiva_DesativaBool(bool selecao){
        Arma1MachadoBool = selecao;
    }

    public static bool returnArma1MachadoAtiva_DesativaBool(){
        return Arma1MachadoBool;
    }

    public void setArma1MachadoAtiva_Desativa(){
        if(returnArma1MachadoAtiva_DesativaBool() == true){
            Arma1Machado.SetActive(true);
        }else{
            Arma1Machado.SetActive(false);
        }
    }

    // Arma2 Espada
    public static void setArma2EspadaAtiva_DesativaBool(bool selecao){
        Arma2EspadaBool = selecao;
    }

    public static bool returnArma2EspadaAtiva_DesativaBool(){
        return Arma2EspadaBool;
    }

    public void setArma2EspadaAtiva_Desativa(){
        if(returnArma2EspadaAtiva_DesativaBool() == true){
            Arma2Espada.SetActive(true);
        }else{
            Arma2Espada.SetActive(false);
        }
    }

    // Arma2 Machado
    public static void setArma2MachadoAtiva_DesativaBool(bool selecao){
        Arma2MachadoBool = selecao;
    }

    public static bool returnArma2MachadoAtiva_DesativaBool(){
        return Arma2MachadoBool;
    }

    public void setArma2MachadoAtiva_Desativa(){
        if(returnArma2MachadoAtiva_DesativaBool() == true){
            Arma2Machado.SetActive(true);
        }else{
            Arma2Machado.SetActive(false);
        }
    }

    //Set Quantidade Inventario
    public void setLifeQuantidadeInventario(string texto){
        quantidadePocoesLifeTextInventario.text = texto;
    }    

    public void setStaminaQuantidadeInventario(string texto){
        quantidadePocoesStaminaTextInventario.text = texto;
    }

    public void setXpQuantidadeInventario(string texto){
        quantidadePocoesXpTextInventario.text = texto;
    }

    public void setBauQuantidadeInventario(string texto){
        quantidadeBauTextInventario.text = texto;
    }


    // Inventario Descricao 

    // Recurso
    public void setDescricaoRecursoPanelItem(){
        if(returnDescricaoRecursoPanelItemBool() == true){
            descricaoRecursoPanelItem.SetActive(true);  
        }else{
            descricaoRecursoPanelItem.SetActive(false);  
        }
    }

    public static void setDescricaoRecursoPanelItemBool(bool selecao){
        descricaoRecursoPanelItemBool = selecao;
    }

    public static bool returnDescricaoRecursoPanelItemBool(){
        return descricaoRecursoPanelItemBool;
    }

    public void setDescricaoRecursoPanelTextHud(string texto){
        descricaoRecursoPanelText.text = texto;
    }

    public static void setDescricaoRecursoPanelText(string texto){
        descricaoRecursoPanelString = texto;
    }

    public static string returnDescricaoRecursoPanelText(){
        return descricaoRecursoPanelString;
    }

    // Durabilidade
    public void setDurabilidadeRecursoPanelItem(){
        if(returnDurabilidadeRecursoPanelItemBool() == true){
            durabilidadeRecursoPanelItem.SetActive(true);  
        }else{
            durabilidadeRecursoPanelItem.SetActive(false);  
        }
    }

    public static void setDurabilidadePanelItemBool(bool selecao){
        durabilidadeRecursoPanelItemBool = selecao;
    }

    public static bool returnDurabilidadeRecursoPanelItemBool(){
        return durabilidadeRecursoPanelItemBool;
    }

    public void setDurabilidadeRecursoPanelTextHud(string texto){
        durabilidadeRecursoPanelText.text = texto;
    }

    public static void setDurabilidadeRecursoPanelText(string texto){
        durabilidadeRecursoPanelString = texto;
    }    
    
    public static string returnDurabilidadeRecursoPanelText(){
        return durabilidadeRecursoPanelString;
    }

    // Nivel
    public void setNivelRecursoPanelItem(){
        if(returnNivelRecursoPanelItemBool() == true){
            nivelRecursoPanelItem.SetActive(true);  
        }else{
            nivelRecursoPanelItem.SetActive(false);  
        }
    }

    public static void setNivelPanelItemBool(bool selecao){
        nivelRecursoPanelItemBool = selecao;
    }

    public static bool returnNivelRecursoPanelItemBool(){
        return nivelRecursoPanelItemBool;
    }

    public void setNivelRecursoPanelTextHud(string texto){
        nivelRecursoPanelText.text = texto;
    }

    public static void setNivelRecursoPanelText(string texto){
        nivelRecursoPanelString = texto;
    }    

    public static string returnNivelRecursoPanelText(){
        return nivelRecursoPanelString;
    }

    // Dano
    public void setDanoRecursoPanelItem(){
        if(returnDanoRecursoPanelItemBool() == true){
            danoRecursoPanelItem.SetActive(true);  
        }else{
            danoRecursoPanelItem.SetActive(false);  
        }
    }

    public static void setDanoPanelItemBool(bool selecao){
        danoRecursoPanelItemBool = selecao;
    }

    public static bool returnDanoRecursoPanelItemBool(){
        return danoRecursoPanelItemBool;
    }

    public void setDanoRecursoPanelTextHud(string texto){
        danoRecursoPanelText.text = texto;
    }

    public static void setDanoRecursoPanelText(string texto){
        danoRecursoPanelString = texto;
    }
       
    public static string returnDanoRecursoPanelText(){
        return danoRecursoPanelString;
    }

}
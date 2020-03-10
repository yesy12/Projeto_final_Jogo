using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventarioHud : MonoBehaviour{

    // Life
    [SerializeField] Text quantidadePocoesLifeText;
    static int quantidadePocoesLifeInt;

    //Stamina
    [SerializeField] Text quantidadePocoesStaminaText;
    static int quantidadePocoesStaminaInt;

    //Xp
    [SerializeField] Text QuantidadePocoesXpText;
    static int quantidadePocoesXpInt;

    void Start(){
        setQuantidadePocoesLife(15);
        setQuantidadePocoesStamina(3);
        setQuantidadePocoesXp(40);
        setPocoesOnHud();
    }

    void Update(){
        setPocoesOnHud();
    }

    public static void setQuantidadePocoesLife(int quantidade,string parametro=""){
        if(parametro == "somar"){
            quantidadePocoesLifeInt += quantidade;
        }
        else if(parametro == "diminuir"){

            quantidadePocoesLifeInt -= quantidade;
        }
        else{
            quantidadePocoesLifeInt = quantidade;
        }
    }

    public static int returnQuantidadePocoesLife(){
        return quantidadePocoesLifeInt;
    }


    public static void setQuantidadePocoesStamina(int quantidade,string parametro=""){
        if(parametro == "somar"){
            quantidadePocoesStaminaInt += quantidade;
        }
        else if(parametro == "diminuir"){

            quantidadePocoesStaminaInt -= quantidade;
        }
        else{
            quantidadePocoesStaminaInt = quantidade;
        }
    }

    public static int returnQuantidadePocoesStamina(){
        return quantidadePocoesStaminaInt;
    }

    public static void setQuantidadePocoesXp(int quantidade,string parametro=""){
        if(parametro == "somar"){
            quantidadePocoesXpInt += quantidade;
        }
        else if(parametro == "diminuir"){

            quantidadePocoesXpInt -= quantidade;
        }
        else{
            quantidadePocoesXpInt = quantidade;
        }
    }

    public static int returnQuantidadePocoesXp(){
        return quantidadePocoesXpInt;
    }


    public void setPocoesOnHud(){
        quantidadePocoesLifeText.text = quantidadePocoesLifeInt.ToString();
        quantidadePocoesStaminaText.text = quantidadePocoesStaminaInt.ToString();
        QuantidadePocoesXpText.text = quantidadePocoesXpInt.ToString();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InimigoText : MonoBehaviour{

    [SerializeField] Text InimigoLife;
    public static int InimigoLifeInt;

    void Update(){ 
        var texto = returnInimigoLifeInt();
        setInimigoLifeHud(texto);
    }

    public void setInimigoLifeHud(string texto){
        InimigoLife.text = texto  + "/100";
    }

    public static string returnInimigoLifeInt(){
        return InimigoLifeInt.ToString();
    }

    public static void setInimigoLifeInt(int valor){
        InimigoLifeInt = valor;
    }
}

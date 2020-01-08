using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderSelected : MonoBehaviour{

    //Arma1
    public GameObject Arma1BorderSelected;
    public GameObject Arma1Border;

     //Arma2
    public GameObject Arma2BorderSelected;
    public GameObject Arma2Border;

    //Life
    public GameObject LifeBorderSelected;
    public GameObject LifeBorder;

     //Stamina
    public GameObject StaminaBorderSelected;
    public GameObject StaminaBorder;

     //Xp
    public GameObject XpBorderSelected;
    public GameObject XpBorder;

    //Bau
    public GameObject BauBorderSelected;
    public GameObject BauBorder;

    public static int ItemSelect;

    void Awake(){
        setItemSelect(0);
    }


    void Update(){
        BorderSelectedSwitch();
    }

    void BorderSelectedSwitch(){
        if(returnItemSelect() == 1){
            Arma1BorderSelected.SetActive(true);
            Arma1Border.SetActive(false);
            dissableBorder();
        }
        else if(returnItemSelect() == 2){
            Arma2BorderSelected.SetActive(true);
            Arma2Border.SetActive(false);
            dissableBorder();
        }
        else if(returnItemSelect() == 3){
            LifeBorderSelected.SetActive(true);
            LifeBorder.SetActive(false);
            dissableBorder();
        }        
        else if(returnItemSelect() == 4){
            StaminaBorderSelected.SetActive(true);
            StaminaBorder.SetActive(false);
            dissableBorder();
        }       
        else if(returnItemSelect() == 5){
            XpBorderSelected.SetActive(true);
            XpBorder.SetActive(false);
            dissableBorder();
        }
        else if(returnItemSelect() == 6){
            BauBorderSelected.SetActive(true);
            BauBorder.SetActive(false);
            dissableBorder();
        }
    }

    public static void setItemSelect(int quantidade){
        ItemSelect = quantidade;
    }

    public static int returnItemSelect(){
        return ItemSelect;
    }

    void dissableBorder(){

    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderSelected : MonoBehaviour{

    //Slot1
    public GameObject Slot1Border;
    public GameObject Slot1BorderSelected;
    

    //Slot2
    public GameObject Slot2Border;
    public GameObject Slot2BorderSelected;

    //Slot3
    public GameObject Slot3Border;
    public GameObject Slot3BorderSelected;

    //Slot4
    public GameObject Slot4Border;
    public GameObject Slot4BorderSelected;

    //Slot5
    public GameObject Slot5Border;
    public GameObject Slot5BorderSelected;

    //Slot6
    public GameObject Slot6Border;
    public GameObject Slot6BorderSelected;

    public static int ItemSelect;
    public static int ultimoItemSelect;
    public static bool destruirUltimoItemSelect;

    void Awake(){
        setItemSelect(0);
    }

    void FixedUpdate(){
        BorderSelectedSwitch();
        if(returnDestruir() == true){
            dissableBorder();
        }
    }

    void BorderSelectedSwitch(){
        if(returnItemSelect() == 1){
            Slot1BorderSelected.SetActive(true);
        }
        else if(returnItemSelect() == 2){
            Slot2BorderSelected.SetActive(true);
        }
        else if(returnItemSelect() == 3){
            Slot3BorderSelected.SetActive(true);
        }
        else if(returnItemSelect() == 4){
            Slot4BorderSelected.SetActive(true);
        }
        else if(returnItemSelect() == 5){
            Slot5BorderSelected.SetActive(true);
        }
        else if(returnItemSelect() == 6){
            Slot6BorderSelected.SetActive(true);
        }
    }

    public static void setItemSelect(int valor){
        ItemSelect = valor;
        if(returnUltimoItemSelect() == 0){
            setUltimoItemSelect(valor);
        }else{
            setDestruir(true);
        }
    }

    public static int returnItemSelect(){
        return ItemSelect;
    }

    public static void setUltimoItemSelect(int valor){
        ultimoItemSelect = valor;
    }

    public static int returnUltimoItemSelect(){
        return ultimoItemSelect;
    }

    public static void setDestruir(bool selecao){
        destruirUltimoItemSelect = selecao;
    }
    
    public static bool returnDestruir(){
        return destruirUltimoItemSelect;
    }


    void dissableBorder(){
        if(returnItemSelect() != returnUltimoItemSelect()){
            if(returnUltimoItemSelect() == 1){
                Slot1BorderSelected.SetActive(false);
            }
            else if(returnUltimoItemSelect() == 2){
                Slot2BorderSelected.SetActive(false);
            }
            else if(returnUltimoItemSelect() == 3){
                Slot3BorderSelected.SetActive(false);
            }
            else if(returnUltimoItemSelect() == 4){
                Slot4BorderSelected.SetActive(false);
            }
            else if(returnUltimoItemSelect() == 5){
                Slot5BorderSelected.SetActive(false);
            }
            else if(returnUltimoItemSelect() == 6){
                Slot6BorderSelected.SetActive(false);
            }
            setUltimoItemSelect(returnItemSelect());
        }
    }
}
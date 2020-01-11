using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemArray : MonoBehaviour{
    public static GameObject[] itens = new GameObject[30];
    public static GameObject Object = null;

    void Start(){

    }

    void FixedUpdate(){
        //MostrarArray();
    }

    public static void AdicionarItem(GameObject itemFunction){
        var pos = 0;
        foreach(GameObject item in itens){
            if(item == null){
                itens[pos] = itemFunction;
            }else{
                pos += 1;
            }
        }
    }

    public static void RemoverItem(GameObject itemFunction){
        var pos = 0;
        foreach(GameObject item in itens){
            if(item == itemFunction){
                itens[pos] = null;
            }
            else{
                pos += 1;
            }
        }
    }



    static void MostrarArray(){
        foreach(GameObject item in itens){
            if(item != null){
                print(item);
            }
        }
    }

    void MostrarLocalizaçao(){
        foreach(GameObject item in itens){
            if(item != null){
                print(item);
            }
        }
    }


}

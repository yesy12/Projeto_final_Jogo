using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour{

    public int teste = 0;

    void Start(){
        ItemArray.AdicionarItem(this.gameObject);
    }

    // Update is called once per frame
    void FixedUpdate(){
        //VerificarArray();
    }

    void VerificarArray(){
        if(teste == 0){
            foreach(GameObject value in ItemArray.itens){
                print(value);
            }
            teste+=1;
        }
    }

}

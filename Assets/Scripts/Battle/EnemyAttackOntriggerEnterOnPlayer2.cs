using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttackOntriggerEnterOnPlayer2 : MonoBehaviour{
 
    void OntriggerEnter(Collider collider){
        var select = collider.tag;


        if(select == "personagem"){
            print(true);
        }
        else{
            print(false);
        }


    }
    
}

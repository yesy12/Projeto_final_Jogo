using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttackOntriggerEnterOnPlayer : MonoBehaviour{
    // Start is called before the first frame update
    void  OnTriggerEnter(Collider collider) {
        var select = collider.tag;

        // if(select == "inimigo"){
        //     print("inimigo");
        // }
    }
}

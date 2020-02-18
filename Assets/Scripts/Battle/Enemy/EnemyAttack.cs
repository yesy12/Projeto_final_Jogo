using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour{

    public Transform person;
    public float velocityEnemy;
    float zeroF;

    void Start(){
        zeroF = 0f;
        velocityEnemy = 10;
    }

    // Update is called once per frame
    void Update(){
        followPlayer();
    }

    void followPlayer(){
        transform.LookAt(person.position);
        transform.Translate(zeroF,zeroF, velocityEnemy * Time.deltaTime);
    }
}

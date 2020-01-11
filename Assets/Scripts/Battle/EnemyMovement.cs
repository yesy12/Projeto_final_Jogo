using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour{

    public Rigidbody myBody;
    public float speed= 7f;

    public Transform playerTarget;

    public float attack_Distance = 1f;
    public float chase_Player_After_Attack = 1f;

    public float current_Attack_Time;
    public float default_Attack_Time = 2f;

    public bool followPlayer;
    public bool attackPlayer;

    public static int life = 20;

    void Awake(){
        myBody = GetComponent<Rigidbody>();

        playerTarget = GameObject.FindWithTag("personagem").transform;
    }


    void Start(){
        followPlayer = true;
        current_Attack_Time = default_Attack_Time;
    }


    void Update(){       
        Attack();
        lifeIsZero();
    }

    void FixedUpdate(){
        FollowTarget();
    }


    void FollowTarget(){
        if(!followPlayer){
            return;
        }
        else{
            
            if(Vector3.Distance(transform.position, playerTarget.position) > attack_Distance){
                transform.LookAt(playerTarget);
                myBody.velocity = transform.forward * speed;

                if(myBody.velocity.sqrMagnitude != 0 ){
                    //print("andando");
                }
            }
            
            else if(Vector3.Distance(transform.position, playerTarget.position) <= attack_Distance){
                
                myBody.velocity = Vector3.zero;
                followPlayer = false;
                attackPlayer = true;

            }   
        }

    }


    void lifeIsZero(){
        if(life < 0) {
            Destroy(this.gameObject);
        }
    }

    void Attack(){
        if(!attackPlayer){
            return;
        }
        else{
            current_Attack_Time += Time.deltaTime;


            if(current_Attack_Time > default_Attack_Time){
                //print("ANIMAÇÃO DE ATAQUE");
                current_Attack_Time = 0f;
                LifeNoPercent.tirarVida(5);
            }


            if(Vector3.Distance(transform.position, playerTarget.position) > attack_Distance + chase_Player_After_Attack){
                attackPlayer = false;
                followPlayer = true;
                
            }
        }


    }

}
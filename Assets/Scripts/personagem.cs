using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personagem : MonoBehaviour{
    float velocPerson,velocPersonRot; 
    Vector3 startPosition;
    public static bool mostrarXP = false;
    public static bool mostrarStamina = false;
    public static bool mostrarVida = false;
    public static int danoArma1;
    public static int danoArma2;
    private static float zeroF = 0f; 

    public static bool apertouE;
    public static bool apertouI;

    void Awake(){
       setApertouE(false);
       setApertouI(false);
    }


    void Start(){
        //DestroyObjectPorDentro = gameObject.GetComponent<DestroyObjectPorDentro>();
        setVelocPerson(30f);
        setVelocPersonRot(90f);
        startPosition = transform.position;
    }

    void Update(){
        movimentacaoPerson();
        controlesGerais();   
    }

    void FixedUpdate(){
        ControlesHudBar();
        //verificarDano();
    }

    public static void verificarDano(){
        if(HudArmaTrue.returnArma1Bool() == true){
            print(returnDanoArma1Personagem() + " Arma1 1");
        }
        if(HudArmaTrue.returnArma2Bool() == true){
            print(returnDanoArma2Personagem() + " Arma 2");
        }
    }
    
    public void setVelocPerson(float quantidade){
        velocPerson = quantidade;
    }

    public float getVelocPerson(){
        return velocPerson;
    }

    public float velocPerson_timeDeltaTime(){
        return velocPerson*Time.deltaTime;
    }
    
    public float velocPersonRot_timeDeltaTime(){
        return velocPersonRot*Time.deltaTime;
    }

    public void setVelocPersonRot(float quantidade){
        velocPersonRot = quantidade;
    }

    //transform.Rotate(0f,-velocPersonRot*Time.deltaTime,0f);
    //transform.Translate(0f,0f,velocPerson*Time.deltaTime);

    void movimentacaoPerson(){
        //x,y,z
        if(Input.GetKey("w")){
            transform.Translate(velocPerson_timeDeltaTime(),zeroF,zeroF);
            // Debug.Log("w");
        }
        else if(Input.GetKey("s")){
            transform.Translate(-velocPerson_timeDeltaTime(),zeroF,zeroF);
        }
        /*
        else if(Input.GetKey("a")){
            transform.Translate(zeroF,zeroF,velocPerson_timeDeltaTime());
        }
        else if(Input.GetKey("d")){
            transform.Translate(zeroF,zeroF,-velocPerson_timeDeltaTime());
        }*/

       else if(Input.GetKey("a")){
            transform.Rotate(zeroF,-velocPersonRot_timeDeltaTime(),zeroF);
        }
        else if(Input.GetKey("d")){
            transform.Rotate(zeroF,velocPersonRot_timeDeltaTime(),zeroF);
        }
    }

    void controlesGerais(){

        if(Input.GetKeyDown("m")){

            //Booleans
            LifeNoPercent.setMostrarVidaBool(true);
            StaminaNoPercent.setMostrarStaminaBool(true);
            XpNoPercent.setMostrarXpBool(true);


            //Situações
            LifeNoPercent.MostrarVida();
            StaminaNoPercent.MostrarStamina();
            XpNoPercent.MostrarXp();
        }
        if(Input.GetKeyUp("m")){
            LifeNoPercent.setMostrarVidaBool(false);
            StaminaNoPercent.setMostrarStaminaBool(false);
            XpNoPercent.setMostrarXpBool(false);
        }

        else if(Input.GetKeyDown("e")){
            setApertouE(true);
        }
        else if(Input.GetKeyDown("l")){
            FaltaDeRecurso.setMessageRecursoTrue(false);
        }
        else if(Input.GetKeyDown("i") && apertouI == false){
            InventarioHud.setInventarioAtiva_DesativaBool(true);
            setApertouI(true);
        }
        else if(Input.GetKeyDown("i") && apertouI == true){
            InventarioHud.setInventarioAtiva_DesativaBool(false);
            InventarioHud.setDescricaoInventarioBoolAtiva_DesativaBool(false);
            setApertouI(false);
        }        
    }

    void ControlesHudBar(){
        if(Input.GetKeyDown("u")){
           StaminaNoPercent.setStaminaAtual(1);
        }
        else if(Input.GetKeyDown("1")){
            if(HudArmaTrue.returnArma1Bool() == true){
                print("Arma 1");
            }
            else{
                FaltaDeRecurso.setMessageRecursoTrue(true);
                FaltaDeRecurso.setMessageRecursoFaltante("1");                
            }
            //HudArmaTrue.Arma1DurabilidadeAtual -= 1;
            BorderSelected.setItemSelect(1);
        }
        else if(Input.GetKeyDown("2")){
            if(HudArmaTrue.returnArma2Bool() == true){
                print("Arma 2");
            }
            else{
                FaltaDeRecurso.setMessageRecursoTrue(true);
                FaltaDeRecurso.setMessageRecursoFaltante("2");                
            }

            //HudArmaTrue.Arma2DurabilidadeAtual -=1;
            BorderSelected.setItemSelect(2);
        }        
        else if(Input.GetKeyDown("3")){           
            if(InventarioHud.returnQuantidadePocoesLifeInt() > 0){
                LifeNoPercent.somarVida(10);
                InventarioHud.diminuirPocoesLife(1);
            }
            else{
                FaltaDeRecurso.setMessageRecursoTrue(true);
                FaltaDeRecurso.setMessageRecursoFaltante("3");
            }  
            BorderSelected.setItemSelect(3);
        }
        else if(Input.GetKeyDown("4")){
            if(InventarioHud.returnQuantidadePocoesStaminaInt() > 0){
                StaminaNoPercent.somarStamina(10);
                InventarioHud.diminuirPocoesStamina(1);
            }
            else{
                FaltaDeRecurso.setMessageRecursoTrue(true);
                FaltaDeRecurso.setMessageRecursoFaltante("4");
            }  
            BorderSelected.setItemSelect(4);
        }
        else if(Input.GetKeyDown("5")){
            if(InventarioHud.returnQuantidadePocoesXpInt() > 0){
                XpNoPercent.somaXp(1);
                InventarioHud.diminuirPocoesXp(1);
            }   
            else{
                FaltaDeRecurso.setMessageRecursoTrue(true);
                FaltaDeRecurso.setMessageRecursoFaltante("5");
            }  
            BorderSelected.setItemSelect(5);    
        }
        else if(Input.GetKeyDown("6")){
            if(InventarioHud.returnQuantidadeBauInt() > 0){
                //XpNoPercent.somaXp(1);
                InventarioHud.diminuirBau(1);
            }   
            else{
                FaltaDeRecurso.setMessageRecursoTrue(true);
                FaltaDeRecurso.setMessageRecursoFaltante("6");
            }  
            BorderSelected.setItemSelect(6);     
        }       
    }

    public static void setApertouE(bool selecao){
        apertouE = selecao;
    }

    public static bool getApertouE(){
        return apertouE;
    }

    public static void setApertouI(bool selecao){
        apertouI = selecao;
    }

    public static bool getApertouI(){
        return apertouI;
    }

    public static void setDanoArma1Personagem(int quantidade){
        danoArma1 = quantidade;
    }

    public static int returnDanoArma1Personagem(){
        return danoArma1;
    }

    public static void setDanoArma2Personagem(int quantidade){
        danoArma2 = quantidade;
    }

    public static int returnDanoArma2Personagem(){
        return danoArma2;
    }


}

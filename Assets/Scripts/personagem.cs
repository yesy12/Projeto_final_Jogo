using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personagem : MonoBehaviour{
    float velocPerson,velocPersonRot; 
    Vector3 startPosition;
    public static bool mostrarXP;
    public static bool mostrarStamina;
    public static bool mostrarVida;
    public static int danoArma1;
    public static int danoArma2;
    private static float zeroF = 0f; 

    public static bool apertouE;
    public static bool apertouI;
    public static string armaSelecionada;
    public static bool ClicouMouse;
    public static bool deuDanoInimigo;

    void Awake(){
       setApertouE(false);
       setApertouI(false);
       setClicouMouse(false);
       setMostrar(false);
    }

    void Start(){
        setVelocPerson(30f);
        setVelocPersonRot(90f);
        startPosition = transform.position;
    }

    void Update(){
        movimentacaoPerson();
        controlesGerais();  
        Click_mouse(); 
        diminuiDurabilidadeArma();
    }

    void FixedUpdate(){
        ControlesHudBar();
    }

    void movimentacaoPerson(){
        //x,y,z
        if(Input.GetKey("w")){
            transform.Translate(velocPerson_timeDeltaTime(),zeroF,zeroF);
            // Debug.Log("w");
        }
        else if(Input.GetKey("s")){
            transform.Translate(-velocPerson_timeDeltaTime(),zeroF,zeroF);
        }

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
        }
        if(Input.GetKeyUp("m")){
            LifeNoPercent.setMostrarVidaBool(false);
            StaminaNoPercent.setMostrarStaminaBool(false);
            XpNoPercent.setMostrarXpBool(false);
        }
        else if(Input.GetKey("g")){
            //Debug.Log(444);
            print(returnDanoArma1Personagem());
        }

        else if(Input.GetKeyDown("e")){
            var arma1 = HudArmaTrue.returnArmaBool("arma1");
            var arma2 = HudArmaTrue.returnArmaBool("arma2");
            if(arma1 == false || arma2 == false){
                setApertouE(true);
            }
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
            if(HudArmaTrue.returnArmaBool("arma1") == true){
                // HudArmaTrue.setDiminuirArma1DurabilidadeAtual(1);
                setArmaSelecionada("arma1");
            }
            else{
                setArmaSelecionada("");  
                FaltaDeRecurso.setMessageRecursoTrue(true);
                FaltaDeRecurso.setMessageRecursoFaltante("1");                
            }
            BorderSelected.setItemSelect(1);
        }
        else if(Input.GetKeyDown("2")){
            if(HudArmaTrue.returnArmaBool("arma2") == true){
                setArmaSelecionada("arma2");
            }
            else{
                setArmaSelecionada("");  
                FaltaDeRecurso.setMessageRecursoTrue(true);
                FaltaDeRecurso.setMessageRecursoFaltante("2");                
            }
            BorderSelected.setItemSelect(2);
        }        
        else if(Input.GetKeyDown("3")){ 
            setArmaSelecionada("");            
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
            setArmaSelecionada("");  
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
            setArmaSelecionada("");  
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
            setArmaSelecionada("0");  
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

    public void diminuiDurabilidadeArma(){
        if(returnArmaSelecionada() == "arma1" && returnDeuDanoInimigo() == true){
            HudArmaTrue.setDiminuirArma1DurabilidadeAtual("arma1",1);
            setDeuDanoinimigo(false);
            StaminaNoPercent.tirarStamina(1);
        }
        else if(returnArmaSelecionada() == "arma2"  && returnDeuDanoInimigo() == true){
            HudArmaTrue.setDiminuirArma1DurabilidadeAtual("arma2",1);
            setDeuDanoinimigo(false);
            StaminaNoPercent.tirarStamina(1);
        }
    }


    void Click_mouse(){
        var arma1Bool = HudArmaTrue.returnArmaBool("arma1");
        var arma2Bool = HudArmaTrue.returnArmaBool("arma2");

        if(arma1Bool == true ||  arma2Bool == true){
            if(Input.GetMouseButtonDown(0)){
                if(returnArmaSelecionada() == "arma1"){
                    setClicouMouse(true);
                }
                else if(returnArmaSelecionada() == "arma2"){
                    setClicouMouse(true);
                }
            }
            if(Input.GetMouseButtonUp(0)){
                setClicouMouse(false);
            }
        }
        else{
            setClicouMouse(false);
            return ;
        }
    }

    
    public static void setDeuDanoinimigo(bool selecao){
        deuDanoInimigo = selecao;
    }

    public static bool returnDeuDanoInimigo(){
        return deuDanoInimigo;
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

    public static void setDanoArmaPersonagem(string selecaoString,int quantidade){
        if(selecaoString == "arma1"){
            danoArma1 = quantidade;
        }
        else if(selecaoString == "arma2"){
            danoArma2 = quantidade;
        }       
    }

    public static int returnDanoArma1Personagem(){
        return danoArma1;
    }

    public static int returnDanoArma2Personagem(){
        return danoArma2;
    }

    public static void setArmaSelecionada(string texto){
        armaSelecionada = texto;
    }

    public static string returnArmaSelecionada(){
        return armaSelecionada;
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

    public static void setClicouMouse(bool selecao){
        ClicouMouse = selecao;
    }

    public static bool getClicouMouse(){
        return ClicouMouse;
    }

    public void setMostrar(bool selecao){
        mostrarXP = selecao;
        mostrarStamina = selecao;
        mostrarVida = selecao;
    }

}

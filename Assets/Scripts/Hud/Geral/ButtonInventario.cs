using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonInventario : MonoBehaviour{

    public static bool clicouBool;
    public static int tempo;
    public static int tempoPadraoFechar;

    void Awake(){
        setClicouBool(false);
        setTempoPadraoFechar(300);
    }

    
    void FixedUpdate(){
        verificarClicouBool();
    }

    public void ButtonClickArma1(){
        setTrueFunction();
        
        setDescricaoRecurso("Espada");   
        setDurabilidade_QuantidadeRecurso("Durabilidade uuu/uuu");
        setNivelRecurso("Nivel 87");  
        setDano_Cura("Dano 87");   
    }

    public void ButtonClickArma2(){
        setTrueFunction();
        
        setDescricaoRecurso("Machado");   
        setDurabilidade_QuantidadeRecurso("Durabilidade yyy/yyy");
        setNivelRecurso("Nivel 7");  
        setDano_Cura("Dano 8");   
    }
    
    public void ButtonClickArma3(){
        setTrueFunction();

        setDescricaoRecurso("Life");   
        setDurabilidade_QuantidadeRecurso("Quantidade bbb/bbb");
        setNivelRecurso("");  
        setDano_Cura("Cura 8");   
    }

    public void ButtonClickArma4(){
        setTrueFunction();
        
        setDescricaoRecurso("Stamina");   
        setDurabilidade_QuantidadeRecurso("Quantidade aaa/aaa");
        setNivelRecurso("");  
        setDano_Cura("Cura 3");   
    }

    public void ButtonClickArma5(){
        setTrueFunction();
        
        setDescricaoRecurso("Xp");       
        setDurabilidade_QuantidadeRecurso("Quantidade xxx/xxx");
        setNivelRecurso("");  
        setDano_Cura("Cura 8");   
    }

    public void ButtonClickArma6(){
        setTrueFunction();
        
        setDescricaoRecurso("Bau");   
        setDurabilidade_QuantidadeRecurso("Quantidade yyy/yyy");

        InventarioHud.setNivelRecursoPanelText("");  

        InventarioHud.setDanoRecursoPanelText("");   
    }

    public static void setTrueFunction(){
        InventarioHud.setDescricaoInventarioBoolAtiva_DesativaBool(true);

        InventarioHud.setDescricaoRecursoPanelItemBool(true);
        InventarioHud.setDurabilidadePanelItemBool(true);
        InventarioHud.setNivelPanelItemBool(true);
        InventarioHud.setDanoPanelItemBool(true);
        setClicouBool(true);
        zerarTempo();
    }

    public static void setClicouBool(bool selecao){
        clicouBool = selecao;
    }

    public static bool returnClicouBool(){
        return clicouBool;
    }

    public void verificarClicouBool(){
        if(returnClicouBool() == true){
            setAumentarTempo();

            if(returnTempo() == returnTempoPadraoFechar()){
                setClicouBool(false);
                setFecharDescricao();
                zerarTempo();
            }
        }
    }

    
    public void setDescricaoRecurso(string texto){
        InventarioHud.setDescricaoRecursoPanelText(texto);
    }

    public void setDurabilidade_QuantidadeRecurso(string texto){
        InventarioHud.setDurabilidadeRecursoPanelText(texto);
    }

    public void setNivelRecurso(string texto){
        InventarioHud.setNivelRecursoPanelText(texto);
    }

    public void setDano_Cura(string texto){
        InventarioHud.setDanoRecursoPanelText(texto);
    }

    public void setFecharDescricao(){
        InventarioHud.setDescricaoInventarioBoolAtiva_DesativaBool(false);
    }

    public static void setTempoPadraoFechar(int quantidade){
        tempoPadraoFechar = quantidade;
    }

    public static int returnTempoPadraoFechar(){
        return tempoPadraoFechar;
    }

    public static void setAumentarTempo(){
        tempo += 1;
    }

    public static int returnTempo(){
        return tempo;
    }

    public static void zerarTempo(){
        tempo = 0;
    }
}
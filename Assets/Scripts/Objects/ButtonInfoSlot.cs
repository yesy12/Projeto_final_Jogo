using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonInfoSlot : MonoBehaviour{

    public static int temporizadorIntInfoSlot;  
    public static bool temporizadorBoolInfoSlot;  

    public static bool arma1EspadaBool;
    public static bool arma1MachadoBool;

    public static int slot;

    void FixedUpdate(){
        contadorTemporizadorIntInfoSlot();
    }

    public void Slot1(){
        if(HudArmaTrue.returnArma1Bool() == true){
            set_HudBarPanel_Temporizador(true);
            setSlot(1);
        
            var slotHudBar = getSlot_HudBar_Panel();
            setSlotHudBarPanel(slotHudBar);

            var descricao = getArmaString_Espada_Machado();
            setDescricaoHudBarPanel(descricao);
            
            var durabilidade = getArmaDurabilidade();
            setDurabilidadeHudPanel(durabilidade);
        
            var nivel = getArmaNivel();
            setNivelHudPanel(nivel);
            
            var dano = getArmaDano();
            setDanoHudPanel(dano);
        }
    }

    public void Slot2(){
        if(HudArmaTrue.returnArma2Bool() == true){
            set_HudBarPanel_Temporizador(true);
            setSlot(2);

            var slotHudBar = getSlot_HudBar_Panel();
            setSlotHudBarPanel(slotHudBar);

            var descricao = getArmaString_Espada_Machado();
            setDescricaoHudBarPanel(descricao);
            
            var durabilidade = getArmaDurabilidade();
            setDurabilidadeHudPanel(durabilidade);
        
            var nivel = getArmaNivel();
            setNivelHudPanel(nivel);
            
            var dano = getArmaDano();
            setDanoHudPanel(dano);
        }
    }

    public void Slot3(){
        setSlot(3);

        var slotHudBar = getSlot_HudBar_Panel();
        setSlotHudBarPanel(slotHudBar);

        set_HudBarPanel_Temporizador(true);
    }
    public void Slot4(){
        setSlot(4);

        var slotHudBar = getSlot_HudBar_Panel();
        setSlotHudBarPanel(slotHudBar);

        set_HudBarPanel_Temporizador(true);
    }

    public void Slot5(){
        setSlot(5);

        var slotHudBar = getSlot_HudBar_Panel();
        setSlotHudBarPanel(slotHudBar);

        set_HudBarPanel_Temporizador(true);
    }
    public void Slot6(){
        setSlot(6);

        var slotHudBar = getSlot_HudBar_Panel();
        setSlotHudBarPanel(slotHudBar);

        set_HudBarPanel_Temporizador(true);
    }


    public string getSlot_HudBar_Panel(){
        var slot = "Slot "+getSlot().ToString();
        return slot;
    }
    public void set_HudBarPanel_Temporizador(bool selecao){
        HudBarPanel.SetItensTrueOrFalse(selecao);
        setTemporizadorBoolInfoSlot(selecao);
    }

    public bool getTemporizadorBoolInfoSlot(){
        return temporizadorBoolInfoSlot;
    }

    public void setTemporizadorBoolInfoSlot(bool selecao){
        temporizadorBoolInfoSlot = selecao;
    }

    public void contadorTemporizadorIntInfoSlot(){
        if(getTemporizadorBoolInfoSlot() == true){
            somaTemporizadorBoolInfoSlot(1);

            if(getTemporizadorIntInfoSlot() == 40){
                set_HudBarPanel_Temporizador(false);
                setTemporizadorBoolInfoSlot(0);
            }
        }
    }

    public void somaTemporizadorBoolInfoSlot(int valor){
        temporizadorIntInfoSlot += valor;
    }

    public void setTemporizadorBoolInfoSlot(int valor){
        temporizadorIntInfoSlot = valor;
    }

    public int getTemporizadorIntInfoSlot(){
        return temporizadorIntInfoSlot;
    }

    public void setSlotHudBarPanel(string valor){
        HudBarPanel.setSlotValor(valor);
    }

    public void setDescricaoHudBarPanel(string valor){
        HudBarPanel.setDescricaoValor(valor);
    }

    public void setDurabilidadeHudPanel(string texto){
        HudBarPanel.setDurabilidadeValor(texto);
    }

    public void setNivelHudPanel(string texto){
        HudBarPanel.setNivelValor(texto);
    }

    public void setDanoHudPanel(string texto){
        HudBarPanel.setDanoValor(texto);
    }

    
    public static void setSlot(int valor){
        slot = valor;
    }

    public static int getSlot(){
        return slot;
    }

    public string getArmaString_Espada_Machado(){
        var armaEspadaBool = false;
        var armaMachadoBool = false;

        if(getSlot() == 1){
            armaEspadaBool = InventarioHud.returnArma1EspadaAtiva_DesativaBool();
            armaMachadoBool = InventarioHud.returnArma1MachadoAtiva_DesativaBool();
        }
        else if(getSlot() == 2){
            armaEspadaBool = InventarioHud.returnArma2EspadaAtiva_DesativaBool();
            armaMachadoBool = InventarioHud.returnArma2MachadoAtiva_DesativaBool();
        }

        var select = "";
        if(armaEspadaBool == true){
            select = "espada";
        }
        else if(armaMachadoBool == true){
            select = "machado";
        }
        return select;
    }

    public string getArmaDurabilidade(){
        var durabilidadeAtual = 0;
        var durabilidadeMaxima = 0;

        if(getSlot() == 1){
            durabilidadeAtual = HudArmaTrue.returnArma1DurabilidadeAtual();
            durabilidadeMaxima = HudArmaTrue.returnArma1DurabilidadeMaxima();
        }
        else if(getSlot() == 2){
            durabilidadeAtual = HudArmaTrue.returnArma2DurabilidadeAtual();
            durabilidadeMaxima = HudArmaTrue.returnArma2DurabilidadeMaxima();
        }

        var durabilidade = durabilidadeAtual +"/" +durabilidadeMaxima;
        return durabilidade;
    }

    public string getArmaNivel(){
        var nivel = "Nivel 0";
        if(getSlot() == 1){
            nivel = "Nivel "+ HudArmaTrue.Arma1Nivel.ToString();
        }
        else if(getSlot() == 2){
            nivel = "Nivel "+ HudArmaTrue.Arma2Nivel.ToString();
        }
        return nivel;
    }

    public string getArmaDano(){
        var dano = "Dano 0";
        if(getSlot() == 1){
            dano = "Dano " + HudArmaTrue.Arma1Dano.ToString();
        }
        else if(getSlot() == 2){
            dano = "Dano " + HudArmaTrue.Arma2Dano.ToString();
        }
        return dano;
    }

}


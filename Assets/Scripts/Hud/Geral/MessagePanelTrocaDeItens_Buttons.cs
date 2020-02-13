using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessagePanelTrocaDeItens_Buttons : MonoBehaviour{
    public MessagePanel messagePanel;
    public string armaString;
    public static bool armaDestruidaBool;

    void Awake(){
        messagePanel = this.GetComponent<MessagePanel>();
    }

    public void buttonArma1(){
        messagePanel.Open_ClosePanelConfirmacaoItem(true);
        armaString = "arma1";
    }

    public void buttonArma2(){
        messagePanel.Open_ClosePanelConfirmacaoItem(true);
        armaString = "arma2";
    }

    public void buttonYes(){
        messagePanel.Open_ClosePanelConfirmacaoItem(false);
        armaDestruidaBool = true;
        HudArmaTrue.setArmaDurabilidadeAtual(armaString,0);
    }

    public void buttonNo(){
        messagePanel.Open_ClosePanelConfirmacaoItem(false);
        print("não");
    }
}

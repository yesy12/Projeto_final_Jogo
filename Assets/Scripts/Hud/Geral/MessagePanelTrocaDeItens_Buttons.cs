using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessagePanelTrocaDeItens_Buttons : MonoBehaviour{
    public MessagePanel messagePanel;

    void Awake(){
        messagePanel = this.GetComponent<MessagePanel>();
    }

    public void buttonArma1(){
        messagePanel.Open_ClosePanelConfirmacaoItem(true);
    }

    public void buttonArma2(){
        messagePanel.Open_ClosePanelConfirmacaoItem(true);
    }

    public void buttonYes(){
        print("sim");
    }

    public void buttonNo(){
        print("não");
    }
}

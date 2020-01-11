using System.Net.NetworkInformation;
using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastingToObject : MonoBehaviour{

    [SerializeField] private Material highlightMaterialEspada;
    [SerializeField] private Material highlightMaterialMachado;
    [SerializeField] private Material highlightMaterialBau;
    public Camera CameraPersonagem;

    void Start(){
        
    }

    private void Update(){
        var ray = CameraPersonagem.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit)){
            var selection = hit.transform;
            var selectionRender = selection.GetComponent<Renderer>();
            
            if(selection.tag == "espada"){
                if(selectionRender != null){
                    selectionRender.material = highlightMaterialEspada;
                }
            }
            else if(selection.tag == "machado"){
                if(selectionRender != null){
                    selectionRender.material = highlightMaterialMachado;
                }
            }
            else if(selection.tag == "bau"){
                if(selectionRender != null){
                    selectionRender.material = highlightMaterialBau;
                }
            }

        }
    }

        
}

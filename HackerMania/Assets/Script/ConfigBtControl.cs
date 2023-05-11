using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;


public class ConfigBtControl : MonoBehaviour
{
   
    // Référence au canvas PanelLogiciel
    public GameObject PanelLogiciel;
    
    
    // Méthode appelée lorsqu'on clique sur le bouton AppControlPortes
    public void OnAppControlPortesClick()
    {
       if(PanelLogiciel != null) {
           PanelLogiciel.SetActive(true);
       }
    }
}

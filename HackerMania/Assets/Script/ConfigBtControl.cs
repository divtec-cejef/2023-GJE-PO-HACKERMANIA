using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;


public class ConfigBtControl : MonoBehaviour
{
   
    // R�f�rence au canvas PanelLogiciel
    public GameObject PanelLogiciel;
    
    
    // M�thode appel�e lorsqu'on clique sur le bouton AppControlPortes
    public void OnAppControlPortesClick()
    {
       if(PanelLogiciel != null) {
           PanelLogiciel.SetActive(true);
       }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelControl : MonoBehaviour
{
   public GameObject PanelLogiciel;

   private void Start()
    {
        PanelLogiciel.SetActive(false); // désactive 
    }

   public void OpenPanel() {
	   if (PanelLogiciel != null) {
		   PanelLogiciel.SetActive(true);
	   }
   }

   public void ClosePanel() {
		PanelLogiciel.SetActive(false);   
   }
}

using UnityEngine;
using UnityEngine.UI;

public class OuvrirPorteButton : MonoBehaviour
{
    public Button ouvrirPorteButton;

    private void Start()
    {
        GlobalVariable.instance.IsPorteSecretariatOpen = true;
        ouvrirPorteButton.onClick.AddListener(OuvrirPorte);
    }

    private void OuvrirPorte()
    {
        if(GlobalVariable.instance.IsPorteSecretariatOpen == true) {
            Debug.Log("SECRETARIAT TERMINER !!!");
        }
    }
}

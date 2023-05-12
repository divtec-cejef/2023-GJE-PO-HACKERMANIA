using UnityEngine;

[CreateAssetMenu(fileName = "GlobalVariable", menuName = "ScriptableObjects/GlobalVariables")]
public class GlobalVariable : ScriptableObject
{
    public static GlobalVariable instance;

    // Ajoutez ici les variables que vous voulez utiliser globalement
    public bool IsPorteSecretariatOpen = false;

    private void OnEnable()
    {
        instance = this;
    }
}
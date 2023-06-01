using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ObjectifAffichage : MonoBehaviour
{
    public TMP_Text texteObjectif; // R�f�rence � l'objet Text
    private int previousObjectifIndex; // Valeur pr�c�dente de ObjectifIndex

    void Start()
    {
        // Mettre � jour le texte initial
        UpdateText();

        // Assigner la valeur initiale de ObjectifIndex � previousObjectifIndex
        previousObjectifIndex = VariablesGlobales.ObjectifIndex;
    }

    void Update()
    {
        // V�rifier si ObjectifIndex est sup�rieur � la valeur pr�c�dente
        if (VariablesGlobales.ObjectifIndex > previousObjectifIndex)
        {
            // Mettre � jour la valeur pr�c�dente avec la nouvelle valeur de ObjectifIndex
            previousObjectifIndex = VariablesGlobales.ObjectifIndex;

            // Mettre � jour le texte avec le nouvel objectif
            UpdateText();
        }
    }

    void UpdateText()
    {
        // V�rifier si l'objet Text est assign�
        if (texteObjectif == null)
        {
            Debug.LogWarning("L'objet Text n'est pas assign� !");
            return;
        }

        // R�cup�rer l'objectif actuel en fonction de la variable ObjectifIndex
        string objectifTexte = GetObjectifActuel(VariablesGlobales.ObjectifIndex);

        // Mettre � jour le texte avec le nouvel objectif
        texteObjectif.text = objectifTexte;
    }

    string GetObjectifActuel(int index)
    {
        // D�finir les objectifs en fonction de leur index
        switch (index)
        {
            case 1:
                return "Objectif 1 : Trouver le PC";
            case 2:
                return "Objectif 2 : Se connecter au PC";
            case 3:
                return "Objectif 3 : Trouver un moyen d'ouvrir la porte";
            case 4:
                return "Objectif 4 : Se rendre dans la salle suivante";
            default:
                return "Objectif inconnu";
        }
    }
}

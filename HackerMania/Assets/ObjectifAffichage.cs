using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ObjectifAffichage : MonoBehaviour
{
    public TMP_Text texteObjectif; // Référence à l'objet Text
    private int previousObjectifIndex; // Valeur précédente de ObjectifIndex

    void Start()
    {
        // Mettre à jour le texte initial
        UpdateText();

        // Assigner la valeur initiale de ObjectifIndex à previousObjectifIndex
        previousObjectifIndex = VariablesGlobales.ObjectifIndex;
    }

    void Update()
    {
        // Vérifier si ObjectifIndex est supérieur à la valeur précédente
        if (VariablesGlobales.ObjectifIndex > previousObjectifIndex)
        {
            // Mettre à jour la valeur précédente avec la nouvelle valeur de ObjectifIndex
            previousObjectifIndex = VariablesGlobales.ObjectifIndex;

            // Mettre à jour le texte avec le nouvel objectif
            UpdateText();
        }
    }

    void UpdateText()
    {
        // Vérifier si l'objet Text est assigné
        if (texteObjectif == null)
        {
            Debug.LogWarning("L'objet Text n'est pas assigné !");
            return;
        }

        // Récupérer l'objectif actuel en fonction de la variable ObjectifIndex
        string objectifTexte = GetObjectifActuel(VariablesGlobales.ObjectifIndex);

        // Mettre à jour le texte avec le nouvel objectif
        texteObjectif.text = objectifTexte;
    }

    string GetObjectifActuel(int index)
    {
        // Définir les objectifs en fonction de leur index
        switch (index)
        {
            case 1:
                return "Objectif 1 : Trouver le PC";
            case 2:
                return "Objectif 2 : Se connecter au PC";
            case 3:
                return "Objectif 3 : Trouver un moyen d'ouvrir la porte";
            case 4:
                return "Objectif 4 : Quitter le secrétariat";
            case 5:
                return "Objectif 5 : Se rendre dans la salle des machines";
            default:
                return "Objectif inconnu";
        }
    }
}

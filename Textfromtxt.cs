/*              Fonction "Textfromtxt" 
 * Permet d'importer des fichiers .txt dans une zone de texte en jeu en fonction de la langue choisie par le joueur
 *  /!\ Nécessite la fonction ChoixLangue pour fonctionner correctement
 *  A mettre comme composant dans le texte à modifier ou le canvas parent
 *  
 * Créé par @jijibay le 28/01/2022
*/

// Librairies utilisées 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Linq;

public class Textfromtxt : MonoBehaviour
{
    public Text Textfiled;                              // Texte à modifier
    public string NomDuFichier;                         // Nom du fichier txt à importer ( doit être le même peut importe la langue )
    private string LangueChoisie = "fr";                // Variable définissant la langue utilisée par défaut (français)

    // Start is called before the first frame update
    void Start()
    {
        Textfiled.text = File.ReadAllText(Application.streamingAssetsPath + "/" + LangueChoisie + "/" + NomDuFichier + ".txt").ToString();              // Récupère le fichier dans le répertoire et l'affiche dans la zone de texte  
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Langue : " + ChoixLangue.langue);                                                                                                  // A utiliser en cas de bug pour voir la langue actuelle
        if (LangueChoisie != ChoixLangue.langue)                                                                                                        // Vérifie si la langue actuelle du texte et la même que celle choisie par le joueur
        {

            Textfiled.text = File.ReadAllText(Application.streamingAssetsPath + "/" + ChoixLangue.langue + "/" + NomDuFichier + ".txt").ToString();     // Récupère le fichier dans le répertoire et l'affiche dans la zone de texte 
            LangueChoisie = ChoixLangue.langue;                                                                                                         // Définie la nouvelle langue actuelle 

        }
    }
}

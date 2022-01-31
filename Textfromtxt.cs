/*              Fonction "Textfromtxt" 
 * Permet d'importer des fichiers .txt dans une zone de texte en jeu en fonction de la langue choisie par le joueur
 *  /!\ N�cessite la fonction ChoixLangue pour fonctionner correctement
 *  A mettre comme composant dans le texte � modifier ou le canvas parent
 *  
 * Cr�� par @jijibay le 28/01/2022
*/

// Librairies utilis�es 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Linq;

public class Textfromtxt : MonoBehaviour
{
    public Text Textfiled;                              // Texte � modifier
    public string NomDuFichier;                         // Nom du fichier txt � importer ( doit �tre le m�me peut importe la langue )
    private string LangueChoisie = "fr";                // Variable d�finissant la langue utilis�e par d�faut (fran�ais)

    // Start is called before the first frame update
    void Start()
    {
        Textfiled.text = File.ReadAllText(Application.streamingAssetsPath + "/" + LangueChoisie + "/" + NomDuFichier + ".txt").ToString();              // R�cup�re le fichier dans le r�pertoire et l'affiche dans la zone de texte  
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Langue : " + ChoixLangue.langue);                                                                                                  // A utiliser en cas de bug pour voir la langue actuelle
        if (LangueChoisie != ChoixLangue.langue)                                                                                                        // V�rifie si la langue actuelle du texte et la m�me que celle choisie par le joueur
        {

            Textfiled.text = File.ReadAllText(Application.streamingAssetsPath + "/" + ChoixLangue.langue + "/" + NomDuFichier + ".txt").ToString();     // R�cup�re le fichier dans le r�pertoire et l'affiche dans la zone de texte 
            LangueChoisie = ChoixLangue.langue;                                                                                                         // D�finie la nouvelle langue actuelle 

        }
    }
}

using UnityEngine;
using System.Collections;
using UnityEditor;

public class SelectAllOfTag : ScriptableWizard
{
    //what you're searching for
    public string searchTag = "Tag to search";

    [MenuItem ("My Tools/Select All Of Tag...")]
    static void SelectAllOfTagWizard()
    {
        //make a button that is interactable. finds whatever you input as the tag
        ScriptableWizard.DisplayWizard<SelectAllOfTag>("Select All Of Tag...", "Make Selection");
    }
    
    void OnWizardCreate()
    {
        //finds all of the gameobjects with the inputted tag and selects them all
        GameObject[] gameObjects = GameObject.FindGameObjectsWithTag(searchTag);
        Selection.objects = gameObjects;
    }
}

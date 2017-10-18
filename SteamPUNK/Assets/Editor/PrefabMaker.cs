using UnityEngine;
using System.Collections;
using UnityEditor;

public class PrefabMaker : ScriptableWizard
{
    [MenuItem("My Tools/Select All Of Tag...")]
    static void SelectAllOfTagWizard()
    {
        //make a button that is interactable. finds whatever you input as the tag
        ScriptableWizard.DisplayWizard<SelectAllOfTag>("GameObject to Prefab", "Make Selection");

    }

    void OnWizardCreate()
    {
        //Selection.objects = 
    }
}

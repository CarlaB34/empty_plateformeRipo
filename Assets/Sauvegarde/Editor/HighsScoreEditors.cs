using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

//customiser la classe de higthsocer
//permet de dire que je custom la classe de cette objet
[CustomEditor(typeof(HightScores))]
public class HighsScoreEditors : Editor
{
    //fonction de editor, inspecteur par defaut est dessiner.
    public override void OnInspectorGUI()
    {
        //base permet d'appler la class mere direct de editor
        base.OnInspectorGUI();

        //permet de dire que tout ce qui a entre le begin et en horizon vont etre alligner sur la meme ligne horizontal
        EditorGUILayout.BeginHorizontal();
        {
            //permet de faire un espace entre les deux bouton
            //EditorGUILayout.Space();

            if (GUILayout.Button("Save"))
            {
                //quand on click sur le bouton applique le higsocr
                //target contient un objet du truc appelr 
                //ma target convertir en hisght score j'appel la fonctin dessus
                //appel le save de higth score
                (target as HightScores).Save();
            }

            //guilayout permet de dessiner des elements d'interface et le layout fait que se soit bien placer et la taille
            if (GUILayout.Button("Load"))
            {

                (target as HightScores).Load();
            }
        }
        // crocher pas obligatoire
        EditorGUILayout.EndHorizontal();
    }

}

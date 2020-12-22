using System.IO; //input omput permet d'acceder et d'ecrire des fichier
using UnityEngine;
using System.Collections.Generic;



[CreateAssetMenu(menuName= "Game/HigScores")]
public class HightScores : ScriptableObject
{
    //public List<PlayerScore> hightScores = new List<PlayerScore>();
    public int score;
   public int ScoreToys;
    public void Save()
    {
        //varible converti en text, converti le jscon en lui meme
        //pour changer la forme du dossier il faut faire un truc de print et le mettre a true
        string json = JsonUtility.ToJson(this, true);

        //va ecraser le contenu =writeAll; indiquer le chemin vers le fichier, mettre le point json pour le convertir/specifier
        // les / pour mettre des espaces
        File.WriteAllText(Application.persistentDataPath + "/save01.json", json);
        //sert a obtenir le chemin vers le dossier , montre l'endroit ou est reanger le dossier qui gere le unity
        //met le chemin dans le debug pou plus de lisibilité
        Debug.Log("File saved at : " +Application.persistentDataPath +"/save01.json");
    }

    public void Load()
    {
        //je lis le fichier pas comme le write qui lui precise l'endroit
        string json = File.ReadAllText(Application.persistentDataPath + "/save01.json");

        //va convertitr le json en class
        JsonUtility.FromJsonOverwrite(json, this);
        Debug.Log("File loaded from : " + Application.persistentDataPath + "/save01.json");
    }


   
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Instantiator : ScriptableObject
{
    [SerializeField]
    private GameObject m_Prefab = null;

    [SerializeField]
    private HightScores m_ScoreRef;

    public void InstantiatePrefab(GameObject p_Prefeab)
    {
        Instantiate(p_Prefeab);
    }

    public void InstantiatePrefab(CollectInfos p_Info)
    {
        Instantiate(m_Prefab, p_Info.position, Quaternion.identity);
    }

    public void InstantiatePrefabInpact(HitInfos p_HitInfo)
    {
        Instantiate(m_Prefab, p_HitInfo.impact, Quaternion.identity);

        
    }

    public void InstantiatePrefabShoot(HitInfos p_HitInfo)
    {
        Instantiate(m_Prefab, p_HitInfo.impact, Quaternion.identity);
        //Inventory.instanceInvantaire.AddCointToys(100);
        //Debug.Log("piece");
        //m_ScoreRef.ScoreToys += 100;
        //m_ScoreRef.Save();
    }

    
}

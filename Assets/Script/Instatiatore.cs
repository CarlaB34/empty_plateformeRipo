using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;

[CreateAssetMenu]
public class Instatiatore : ScriptableObject
{
    [SerializeField]
    private GameObject m_Prefab = null;
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
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpObjet : MonoBehaviour
{
    [SerializeField]
    private GameObject m_SpSars;
    
    [SerializeField]
    private GameObject m_SpToys;
    [SerializeField]
    private HightScores m_ScoreRef;
    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.layer== 10 && m_SpSars)
        {
            Inventory.instanceInvantaire.AddCointsDiamant(100);
            m_ScoreRef.score += 100;
            //Debug.LogError("piece");
            m_ScoreRef.Save();
        }

        if (collision.gameObject.layer == 11 && m_SpToys)
        {
          
        }
    }

    public void DeathCollisionToys()
    {
       //if( p_Infos.position = m_SpToys)
       // {

       // }
        Inventory.instanceInvantaire.AddCointToys(100);
        Debug.Log("piece");
        m_ScoreRef.ScoreToys += 100;
        m_ScoreRef.Save();
    }
}


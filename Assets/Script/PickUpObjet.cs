using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpObjet : MonoBehaviour
{
    [SerializeField]
    private GameObject m_spSars;
    [SerializeField]
    private HightScores m_ScoreRef;
    private void OnTriggerEnter(Collider collision)
    {
        if(collision.CompareTag( "Player") && m_spSars)
        {
            Inventory.instanceInvantaire.AddCointsDiamant(1);
            Debug.Log("piece");
            m_ScoreRef.Save();
        }
    }
}


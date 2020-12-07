﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{

    [SerializeField]
    private int m_CoinCountSugar;

    

    [SerializeField]
    private Text m_CoinCountTexSugar;


    [SerializeField]
    private HightScores m_ScoreRef;

    public static Inventory instanceInvantaire;

    private void Awake()
    {
        m_ScoreRef.Save();

        if (instanceInvantaire != null)
        {
            Debug.Log("il y a plus d'une instance de inventory dans la scene");
            return;
        }

        instanceInvantaire = this;
    }

    
    public void AddCointsDiamant(int p_Count)
    {

        m_CoinCountSugar += p_Count;
        m_CoinCountTexSugar.text = m_CoinCountSugar.ToString();
        // m_CoinCountTexStars.text =  m_ScoreRef.score.ToString();

    }


}
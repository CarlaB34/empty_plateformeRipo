using System.Collections;
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
    private int m_CoinToys;

    [SerializeField]
    private Text m_CoinToysText;

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

    }

    public void AddCointToys(int p_count)
    {
        m_CoinToys += p_count;
        m_CoinToysText.text = m_CoinToys.ToString();
    }

    public void ResetCoints()
    {
        m_CoinCountTexSugar.text = m_CoinCountSugar.ToString("0");
        m_ScoreRef.score = 0;
        m_ScoreRef.ScoreToys = 0;
        m_CoinToysText.text = "0";
        m_ScoreRef.Save();
    }
}

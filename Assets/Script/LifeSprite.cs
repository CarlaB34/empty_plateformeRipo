using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeSprite : MonoBehaviour
{
    [SerializeField]
    private Image[] m_spriteLife;

    [SerializeField]
    private int m_Health = 3;

    public void UpdateLifeCollision()
    {
        UpdateLife(-1);
    }
    private void UpdateLife(int addAmount) //ajoute une valeur a playerHealth
    {
        

        m_Health += addAmount;
        UpdateLifeUI();
    }
    private void UpdateLifeUI()
    {
        for (int i = 0; i < m_spriteLife.Length; i++)
        {
            bool isSpriteAcitve = i < m_Health;
            m_spriteLife[i].gameObject.SetActive(!isSpriteAcitve);
        }
    }

    public void DeathLife()
    {
        if(m_Health <=0)
        {
            Debug.LogError("endGame");
        }
    }
}

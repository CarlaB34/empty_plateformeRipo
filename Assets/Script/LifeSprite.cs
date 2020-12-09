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

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer == 11)
        {
            Debug.LogError("toucher0");
        }
    }
    public void UpdateLife(int addAmount) //ajoute une valeur a playerHealth
    {
        Debug.LogError("toucher0");

        m_Health += addAmount;
        UpdateLifeUI();
    }
    public void UpdateLifeUI()
    {
        for (int i = 0; i < m_spriteLife.Length; i++)
        {
            bool isSpriteAcitve = i < m_Health;
            m_spriteLife[i].gameObject.SetActive(!isSpriteAcitve);
        }
    }
}

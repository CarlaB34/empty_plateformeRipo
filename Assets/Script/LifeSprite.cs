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
    [SerializeField]
    private CameraShake m_CameraShake;
    public void UpdatLifeCollision()
    {
        UpdateLife(-1);
        StartCoroutine(m_CameraShake.Shake(0.15f, 0.5f));

    }
    public void UpdatNoLife()
    {
        UpdateLife(4);
        StopCoroutine(m_CameraShake.Shake(0,0));
        m_Health = 4;
    }
    private void UpdateLife(int addAmount) //ajoute une valeur a playerHealth
    {
        Debug.Log("toucher0");

        m_Health += addAmount;
        UpdateLifeUI();
    }
    private void UpdateLifeUI()
    {
        for (int i = 0; i < m_spriteLife.Length; i++)
        {
            //permet d'activer un sprite qui correspond a une vie tant que i est inferieur a m_health
            bool l_IsSpriteAcitve = i < m_Health;
            m_spriteLife[i].gameObject.SetActive(!l_IsSpriteAcitve);

            Debug.Log(i);
        }
    }

  
    private void DeathLife()
    {
        if (m_Health <= 0)
        {
            Debug.LogError("endGame");
            m_Health = 3;
           // UpdateLife(3);
           
        }
    }
}

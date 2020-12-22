using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuEnd : MonoBehaviour
{
    [SerializeField]
    private GameObject m_MenuEndPanel;
    [SerializeField]
    private HightScores m_ScoreRef;
    [SerializeField]
    private CameraShake m_CameraShake;
    // Start is called before the first frame update
    void Start()
    {
       // m_MenuEndPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        StopCoroutine(m_CameraShake.Shake(0, 0));
        m_ScoreRef.Save();
       // Time.timeScale = 0;

    }
    public void ResetLife()
    {

    }

    public void ButtonRestart()
    {
        Time.timeScale = 1;
        m_MenuEndPanel.SetActive(false);
        ResetLife();
    }
}

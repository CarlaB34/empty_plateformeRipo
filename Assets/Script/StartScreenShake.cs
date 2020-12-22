using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScreenShake : MonoBehaviour
{
    [SerializeField]
    private CameraShake m_CameraShake;
    public void ScreenShakeDamage(DamagesInfos p_DamagesInfo)
    {
        StartCoroutine(m_CameraShake.Shake(0.0f, 0.05f));
    }
}

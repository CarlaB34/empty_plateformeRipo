using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public IEnumerator Shake(float p_Duration, float p_Magnitude)
    {
        Vector3 l_OrigniPosition = transform.localPosition;
        float l_Elapsed = 0.0f;

        while (l_Elapsed < p_Duration)
        {
            float l_X = Random.Range(-3, 3f) * p_Magnitude;
            float l_Y = Random.Range(-3f, 3f) * p_Magnitude;

            transform.localPosition = new Vector3(l_X, l_Y, l_OrigniPosition.z);

            l_Elapsed += Time.deltaTime;

            yield return null;
        }
        transform.localPosition = l_OrigniPosition;

    }
}

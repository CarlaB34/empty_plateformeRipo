using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public void DirectionGun(AimInfos p_Infos)
    {
        transform.right = p_Infos.direction;
    }
}

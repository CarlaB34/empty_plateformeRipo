using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationMove : MonoBehaviour
{
    private Animator m_Anim;
    private int m_SpeedAnim = 8;
    private float m_TimerShoot = 1;
    // Start is called before the first frame update
    void Start()
    {
        m_Anim = GetComponent<Animator>();
    }

    private void Update()
    {

    }
    public void AnimationGlisser(MovementInfos p_Info)
    {
        Debug.Log("AnimationGlisser");
        // p_Info.speed = m_SpeedAnim;
        if (p_Info.speed == m_SpeedAnim)
        {
            Debug.Log("animation");
            m_Anim.SetBool("IsRunning", true);


        }

    }

    public void AnimationNOGlisser()
    {

        m_Anim.SetBool("IsRunning", false);
        Debug.Log("idle");

    }

    public void AnimationShoot(ShootInfos p_Info)
    {
      //  m_TimerShoot = p_Info.cooldown;
   
        Debug.Log("animationShoot");

        m_Anim.SetTrigger("ShootTrigger");

    }

    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private Animation anim;

    private void Awake()
    {
        anim = GetComponent<Animation>();
    }

    public void PlayAnimation()
    {
        if (anim.enabled == false)
        {
            anim.enabled = true;
            anim.Play("Deserto");
        }
    }

    public void PauseAnimation()
    {
        anim.enabled = false;
    }
}

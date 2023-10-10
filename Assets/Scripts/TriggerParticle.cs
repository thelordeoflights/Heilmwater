using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerParticle : StateMachineBehaviour
{
    public GameObject objectWithPS;


    public override void OnStateEnter(Animator animator, AnimatorStateInfo animatorStateInfo, int layerIndex)
    {
        var particleSystem = objectWithPS.GetComponent<ParticleSystem>();

        if (particleSystem != null)
        {
            particleSystem.Play();
        }

    }

}

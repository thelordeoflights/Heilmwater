using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEffectController : MonoBehaviour
{


    public Transform EffectsParent;
    public GameObject special1Prefab, special2Prefab;

    GameObject currentActive;



    public void TriggerSpecial1()
    {
        if (currentActive)
        {
            Destroy(currentActive);
        }
        currentActive = Instantiate(special1Prefab, EffectsParent, true);

    }
    public void TriggerSpecial2()
    {
        if (currentActive)
        {
            Destroy(currentActive);
        }
        currentActive = Instantiate(special2Prefab, EffectsParent, true);
    }


}


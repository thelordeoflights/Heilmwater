using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class katana : MonoBehaviour, IWeapon
{
    CarrierSystem cs;
    public void onAttachedCarrier(CarrierSystem attachedCarrier)
    {

        cs = attachedCarrier;
    }

    public void onEquip()
    {
    }

    public void OnMelee(InputAction.CallbackContext context)
    {
        if (cs != null)
            cs.playeranimator.SetTrigger("melee");
    }

    public void OnSpecial1(InputAction.CallbackContext context)
    {
        if (cs != null)
            cs.playeranimator.SetTrigger("special1");
    }

    public void OnSpecial2(InputAction.CallbackContext context)
    {
        if (cs != null)
            cs.playeranimator.SetTrigger("special2");
    }

    public void OnSwitch(InputAction.CallbackContext context)
    {
    }

    public void onUnequip()
    {
    }
}

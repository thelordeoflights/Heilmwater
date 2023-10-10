using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IWeapon : Weaponactions.IWeaponactionActions
{
    void onAttachedCarrier(CarrierSystem attachedCarrier);
    void onEquip();
    void onUnequip();
}



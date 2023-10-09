using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CarrierSystem : MonoBehaviour, Weaponactions.IWeaponactionActions
{
    public List<WeaponScriptable> equipableWeapons;
    public Transform playerSocket;
    public Animator playeranimator;
    int currentweaponindex = 0;

    IWeapon currentWeaponInterface;
    GameObject currentWeapongameObject;
    WeaponScriptable currentWeaponS;
    void switchWeapons(WeaponScriptable weapon)
    {
        if (weapon == currentWeaponS)
        {
            return;
        }
        Destroy(currentWeapongameObject);
        currentWeaponS = weapon;
        currentWeapongameObject = Instantiate(weapon.weaponPrefab, playerSocket, true);
        currentWeapongameObject.transform.localPosition = Vector3.zero;
        currentWeapongameObject.transform.localRotation = Quaternion.identity;

        currentWeaponInterface = currentWeapongameObject.GetComponentInChildren<IWeapon>();
        if (currentWeaponInterface == null)
        {
            DestroyImmediate(currentWeapongameObject);
            currentWeaponInterface = null;
            currentWeapongameObject = null;
            currentWeaponS = null;
        }
        else
        {
            currentWeaponInterface.onAttachedCarrier(this);
            currentWeaponInterface.onEquip();
            playeranimator.runtimeAnimatorController = currentWeaponS.playerAnimationController;
        }
    }
    void Awake()
    {
        switchWeapons(equipableWeapons[currentweaponindex]);
    }
    public void OnMelee(InputAction.CallbackContext context)
    {
        if (currentWeaponInterface != null)
        {
            currentWeaponInterface.OnMelee(context);
        }
    }

    public void OnSpecial1(InputAction.CallbackContext context)
    {
        if (currentWeaponInterface != null)
        {
            currentWeaponInterface.OnSpecial1(context);
        }
    }

    public void OnSpecial2(InputAction.CallbackContext context)
    {
        if (currentWeaponInterface != null)
        {
            currentWeaponInterface.OnSpecial2(context);
        }
    }

    public void OnSwitch(InputAction.CallbackContext context)
    {
        currentweaponindex = (currentweaponindex + 1) % equipableWeapons.Count;
        switchWeapons(equipableWeapons[currentweaponindex]);
    }
}
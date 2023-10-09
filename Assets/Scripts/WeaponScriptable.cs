using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "WeaponsScr", menuName = "Scriptable/weapons")]
public class WeaponScriptable : ScriptableObject
{
    public GameObject weaponPrefab;

    public RuntimeAnimatorController playerAnimationController;
}


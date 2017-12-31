using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Weapon : EquippableItem
{
    public int AttackPower;
    public WeaponType Type;
}

public enum WeaponType
{
    OneHanded, TwoHanded, Shield
}
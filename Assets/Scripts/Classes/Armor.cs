using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Armor : EquippableItem
{
    public int ArmorPoints;
    public ArmorType Type;
}

public enum ArmorType
{
    Cloth, Leather, Plate
}
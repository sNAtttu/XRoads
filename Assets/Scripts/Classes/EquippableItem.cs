using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class EquippableItem
{
    public int Id;
    public int Durability;
    public int MaxDurability;

    public string Name;
    public string PrefabName;
}

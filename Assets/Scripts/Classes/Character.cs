﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Character
{
    public int Coins;
    public int Lives;
    public int FoodAmount;

    public string SelectedPrefab;
    public Inventory Inventory;
}

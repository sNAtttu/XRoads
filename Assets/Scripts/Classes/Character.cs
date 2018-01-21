using System;

namespace Classes
{
    [Serializable]
    public class Character
    {
        public string Name;
        public string Description;

        public int Coins;
        public int Lives;
        public int FoodAmount;
        public int Strength;

        public Inventory Inventory;
    }
}

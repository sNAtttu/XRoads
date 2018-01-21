using System;

namespace Classes
{
    [Serializable]
    public class User
    {
        public string Username;
        public Settings Settings;
        public Character Character;
        public bool CharacterCreated = false;
    }
}

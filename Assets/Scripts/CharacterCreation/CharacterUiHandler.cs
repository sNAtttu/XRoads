using Player;
using UnityEngine;
using UnityEngine.UI;

namespace CharacterCreation
{
    public class CharacterUiHandler : MonoBehaviour
    {
        public Text SelectedCharacterNameText;
        public Text SelectedCharacterDescription;

        public void SetCharacterNameText(PlayerInformation playerInformation)
        {
            if (playerInformation.CharacterType == null) return;
            SelectedCharacterNameText.text = playerInformation.CharacterType.Name;
            SelectedCharacterDescription.text = playerInformation.CharacterType.Description;

        }
    }
}
using System.Collections.Generic;
using System.Linq;
using Classes;
using Helpers;
using Player;
using Services;
using UnityEngine;

namespace CharacterCreation
{
    public class CharacterCreationMessages : MonoBehaviour
    {
        public List<GameObject> CharactersAvailable;

        private void Start()
        {
            SelectLuckCharacter();
        }

        public void SaveCharacter()
        {
            var userData = FileService.UserData ?? FileService.LoadData<User>(Constants.PathUserdata);
            var selectedCharacter = CharactersAvailable.FirstOrDefault(c => c.activeSelf);
            if(userData != null && selectedCharacter != null)
            {
                userData.CharacterCreated = true;
                FileService.SaveObject<User>(userData, Constants.PathUserdata);
            }
            else
            {
                Debug.LogWarning("User hasn't selected character or data json is not in cache");
            }
        }


        public void SelectLuckCharacter()
        {
            GetComponent<PlayMakerFSM>().SendEvent(CharacterCreationConstants.EventSelectLuck);
            var selectedCharacter = CharactersAvailable.FirstOrDefault(c => c.activeSelf);
            if (selectedCharacter != null)
                GetComponent<CharacterUiHandler>()
                    .SetCharacterNameText(selectedCharacter.GetComponent<PlayerInformation>());
           
        }
        public void SelectStrengthCharacter()
        {
            GetComponent<PlayMakerFSM>().SendEvent(CharacterCreationConstants.EventSelectStrength);
            var selectedCharacter = CharactersAvailable.FirstOrDefault(c => c.activeSelf);
            if (selectedCharacter != null)
                GetComponent<CharacterUiHandler>()
                    .SetCharacterNameText(selectedCharacter.GetComponent<PlayerInformation>());
            
        }
        public void SelectCoinCharacter()
        {
            GetComponent<PlayMakerFSM>().SendEvent(CharacterCreationConstants.EventSelectCoin);
            var selectedCharacter = CharactersAvailable.FirstOrDefault(c => c.activeSelf);
            if (selectedCharacter != null)
                GetComponent<CharacterUiHandler>()
                    .SetCharacterNameText(selectedCharacter.GetComponent<PlayerInformation>());
            
        }
    }
}

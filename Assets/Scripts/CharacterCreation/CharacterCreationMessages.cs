using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class CharacterCreationMessages : MonoBehaviour
{
    public List<GameObject> CharactersAvailable;

    public void SaveCharacter()
    {
        var userData = FileService.UserData;
        if(userData == null)
        {
            userData = FileService.LoadData<User>(Constants.PATH_USERDATA);
        }
        var selectedCharacter = CharactersAvailable.Where(c => c.activeSelf).FirstOrDefault();
        if(userData != null && selectedCharacter != null)
        {
            userData.Character.SelectedPrefab = selectedCharacter.name;
            userData.CharacterCreated = true;
            FileService.SaveObject<User>(userData, Constants.PATH_USERDATA);
        }
        else
        {
            Debug.LogWarning("User hasn't selected character or data json is not in cache");
        }
    }
}

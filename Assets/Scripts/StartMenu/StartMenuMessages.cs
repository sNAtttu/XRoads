using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class StartMenuMessages : MonoBehaviour
{
    private PlayMakerFSM UIManagerFSM;
    private StartMenuUIManager UIManager;

    private void Awake()
    {
        UIManagerFSM = GetComponent<PlayMakerFSM>();
        UIManager = GetComponent<StartMenuUIManager>();
    }

    public void LoadUserProfile()
    {
        try
        {
            var userData = FileService.LoadData<User>(Constants.PATH_USERDATA);
            FileService.UserData = userData;
            UIManagerFSM.SendEvent(StartMenuConstants.EVENT_SETTINGSFOUND);
            UIManager.SetWelcomeTitle(userData.Username);
            if(userData.CharacterCreated)
            {
                UIManager.EnableContinueButton();
            }
        }
        catch (FileNotFoundException)
        {
            Debug.Log("Settings not found, send event");
            UIManagerFSM.SendEvent(StartMenuConstants.EVENT_SETTINGSNOTFOUND);
        }
        catch (DirectoryNotFoundException)
        {
            Debug.Log("Directory not found, send event");
            UIManagerFSM.SendEvent(StartMenuConstants.EVENT_SETTINGSNOTFOUND);
        }
        catch (Exception)
        {
            UIManagerFSM.SendEvent(StartMenuConstants.EVENT_SETTINGSNOTFOUND);
        }
    }

    public void EnableAll(bool value)
    {
        Debug.Log("Mute all: " + value);
    }
    public void EnableSounds(bool value)
    {
        Debug.Log("Mute sounds " + value);
    }
    public void EnableMusic(bool value)
    {
        Debug.Log("Mute music: " + value);
    }

    public void SaveUserAndCreateSettingsFile()
    {
        var usernameText = GameObject.FindGameObjectWithTag("UsernameInput").GetComponent<InputField>().text;
        User user = new User
        {
            Username = usernameText,
            Settings = new Settings
            {
                AllSoundOn = true,
                MusicOn = true,
                SoundOn = true,
            },
            Character = null
        };
        FileService.SaveObject<User>(user, Constants.PATH_USERDATA);
        UIManager.SetWelcomeTitle(usernameText);
    }

}

using System;
using System.IO;
using Classes;
using Helpers;
using Services;
using UnityEngine;
using UnityEngine.UI;

namespace StartMenu
{
    public class StartMenuMessages : MonoBehaviour
    {
        private PlayMakerFSM _uiManagerFsm;
        private StartMenuUiManager _uiManager;

        private void Awake()
        {
            _uiManagerFsm = GetComponent<PlayMakerFSM>();
            _uiManager = GetComponent<StartMenuUiManager>();
        }

        public void LoadUserProfile()
        {
            try
            {
                var userData = FileService.LoadData<User>(Constants.PathUserdata);
                FileService.UserData = userData;
                _uiManagerFsm.SendEvent(StartMenuConstants.EventSettingsfound);
                _uiManager.SetWelcomeTitle(userData.Username);
                if(userData.CharacterCreated)
                {
                    _uiManager.EnableContinueButton();
                }
            }
            catch (FileNotFoundException)
            {
                Debug.Log("Settings not found, send event");
                _uiManagerFsm.SendEvent(StartMenuConstants.EventSettingsnotfound);
            }
            catch (DirectoryNotFoundException)
            {
                Debug.Log("Directory not found, send event");
                _uiManagerFsm.SendEvent(StartMenuConstants.EventSettingsnotfound);
            }
            catch (Exception)
            {
                _uiManagerFsm.SendEvent(StartMenuConstants.EventSettingsnotfound);
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
            FileService.SaveObject<User>(user, Constants.PathUserdata);
            _uiManager.SetWelcomeTitle(usernameText);
        }

    }
}

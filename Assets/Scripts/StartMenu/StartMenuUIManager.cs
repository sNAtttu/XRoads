using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartMenuUiManager : MonoBehaviour
{
    public Text WelcomeTitle;
    public GameObject ContinueBtn;

    public void SetWelcomeTitle(string username)
    {
        WelcomeTitle.text = string.Format("Welcome {0}!", username);
    }

    public void EnableContinueButton()
    {
        if (!ContinueBtn.activeSelf)
        {
            ContinueBtn.SetActive(true);
        }
    }

}

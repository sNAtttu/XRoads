using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartMenuUIManager : MonoBehaviour
{
    public Text WelcomeTitle;

    public void SetWelcomeTitle(string username)
    {
        WelcomeTitle.text = string.Format("Welcome {0}!", username);
    }

}

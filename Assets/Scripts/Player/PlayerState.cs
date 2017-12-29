using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayMakerFSM))]
public class PlayerState : MonoBehaviour
{
    private PlayMakerFSM playerFSM;
    private GameObject crossingPlayerEntered;

    public GameObject CrossingPlayerEntered
    {
        get
        {
            return crossingPlayerEntered;
        }

        set
        {
            if(value.GetComponent<Crossing>() != null)
            {
                crossingPlayerEntered = value;
            }
            else
            {
                crossingPlayerEntered = null;
            }
        }
    }

    // Use this for initialization
    void Awake()
    {
        playerFSM = GetComponent<PlayMakerFSM>();
    }

    public string GetPlayerState()
    {
        return playerFSM.ActiveStateName;
    }

    public void SendPlayerEvent(string playerEvent)
    {
        if (!string.IsNullOrEmpty(playerEvent))
        {
            playerFSM.SendEvent(playerEvent);
        }
    }

    public void StartScene()
    {
        if(GetPlayerState() == "Init")
        {
            SendPlayerEvent("Run");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == Constants.TAG_GROUNDBEFORECROSSING)
        {
            SendPlayerEvent(PlayerConstants.EVENT_WALK);
        }
        else if(other.tag == Constants.TAG_CROSSING)
        {
            CrossingPlayerEntered = other.gameObject;
            SendPlayerEvent(PlayerConstants.EVENT_HITCROSSING);
        }
        else if (other.tag == Constants.TAG_MIDDLEPOINT)
        {
            SendPlayerEvent(PlayerConstants.EVENT_MIDDLEOFCROSSING);
        }
        else if(other.tag == Constants.TAG_GROUNDAFTERCROSSING)
        {
            Debug.Log("After the crossing");
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == Constants.TAG_GROUNDBEFORECROSSING)
        {
            Debug.Log("Leaving from ground before");
        }
        else if (other.tag == Constants.TAG_CROSSING)
        {
            Debug.Log("Leaving crossing");
        }
        else if (other.tag == Constants.TAG_GROUNDAFTERCROSSING)
        {
            Debug.Log("Leaving to normal ground");
        }
    }
}

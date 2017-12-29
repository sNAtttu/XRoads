using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PlayerInputMessages : MonoBehaviour
{

    public bool CheckUserInputIsAllowed(Constants.Directions direction)
    {
        var allowedDirections = GetComponent<PlayerState>()
            .CrossingPlayerEntered
            .GetComponent<Crossing>().AllowedDirections;

        if (allowedDirections.Contains(direction))
        {
            return true;
        }
        else
        {
            GetComponent<PlayerState>().SendPlayerEvent(PlayerConstants.EVENT_INVALIDINPUT);
            return false;
        }

    }

    public void Rotate(Constants.Directions direction)
    {
        if (CheckUserInputIsAllowed(direction))
        {
            StartCoroutine(ContinuousRotation(direction));
        }    
    }

    IEnumerator ContinuousRotation(Constants.Directions direction)
    {
        var playerState = GetComponent<PlayerState>();
        int degrees = 90;
        int turnDirection = 1;
        if (direction == Constants.Directions.Backward)
            degrees = 180;    
        if (direction == Constants.Directions.Left)
            turnDirection = -1;
        if(direction != Constants.Directions.Forward)
        {
            for (var i = 0; i <= degrees; i++)
            {
                transform.Rotate(Vector3.up, turnDirection);
                yield return new WaitForSeconds(0.01f);
            }
        }
        if(playerState.GetPlayerState() == PlayerConstants.STATE_CHOOSELEFT ||
            playerState.GetPlayerState() == PlayerConstants.STATE_CHOOSERIGHT || 
            playerState.GetPlayerState() == PlayerConstants.STATE_CHOOSEFORWARD ||
           playerState.GetPlayerState() == PlayerConstants.STATE_CHOOSEBACKWARD)
        {
            playerState.SendPlayerEvent(PlayerConstants.EVENT_LEAVECROSSING);
        }
    }

}

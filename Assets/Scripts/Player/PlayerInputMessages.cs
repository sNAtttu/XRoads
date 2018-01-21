using System.Collections;
using Helpers;
using UnityEngine;

namespace Player
{
    public class PlayerInputMessages : MonoBehaviour
    {

        public bool CheckUserInputIsAllowed(Constants.Directions direction)
        {
            var allowedDirections = GetComponent<PlayerState>()
                .CrossingPlayerEntered
                .GetComponent<Crossing.Crossing>().AllowedDirections;

            if (allowedDirections.Contains(direction))
            {
                return true;
            }
            else
            {
                GetComponent<PlayerState>().SendPlayerEvent(PlayerConstants.EventInvalidinput);
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
            if(playerState.GetPlayerState() == PlayerConstants.StateChooseleft ||
               playerState.GetPlayerState() == PlayerConstants.StateChooseright || 
               playerState.GetPlayerState() == PlayerConstants.StateChooseforward ||
               playerState.GetPlayerState() == PlayerConstants.StateChoosebackward)
            {
                playerState.SendPlayerEvent(PlayerConstants.EventLeavecrossing);
            }
        }

    }
}

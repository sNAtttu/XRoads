using Helpers;
using UnityEngine;

namespace Player
{
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerMovement : MonoBehaviour
    {
        public float RunSpeed = 5;
        public float WalkSpeed = 2f;

        private PlayerState _playerState;
        private Rigidbody _playerBody;
        // Use this for initialization
        void Awake()
        {
            _playerBody = GetComponent<Rigidbody>();
            _playerState = GetComponent<PlayerState>();
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            if(_playerState.GetPlayerState() == PlayerConstants.StateRunning)
            {
                _playerBody.velocity = transform.forward * RunSpeed;
            }
            else if(_playerState.GetPlayerState() == PlayerConstants.StateComingtocrossing)
            {
                _playerBody.velocity = transform.forward * RunSpeed;
            }
            else if(_playerState.GetPlayerState() == PlayerConstants.StateCrossingboundaries)
            {
                transform.position = Vector3.MoveTowards(transform.position, _playerState.CrossingPlayerEntered.GetComponent<Crossing.Crossing>().GetMiddlePointLocation(), WalkSpeed * Time.fixedDeltaTime);
            }
            else if(_playerState.GetPlayerState() == PlayerConstants.StateAtcrossing)
            {
                _playerBody.velocity = new Vector3();
            }
            else if(_playerState.GetPlayerState() == PlayerConstants.StateLeavingcrossing)
            {
                _playerBody.velocity = transform.forward * RunSpeed;
            }
        }
    }
}

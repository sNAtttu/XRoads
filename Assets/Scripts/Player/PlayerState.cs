using Helpers;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Player
{
    [RequireComponent(typeof(PlayMakerFSM))]
    public class PlayerState : MonoBehaviour
    {
        private PlayMakerFSM _playerFsm;
        private GameObject _crossingPlayerEntered;

        public GameObject CrossingPlayerEntered
        {
            get
            {
                return _crossingPlayerEntered;
            }

            set
            {
                if(value.GetComponent<Crossing.Crossing>() != null)
                {
                    _crossingPlayerEntered = value;
                }
                else
                {
                    _crossingPlayerEntered = null;
                }
            }
        }

        // Use this for initialization
        void Awake()
        {
            _playerFsm = GetComponent<PlayMakerFSM>();
        }

        public string GetPlayerState()
        {
            return _playerFsm.ActiveStateName;
        }

        public void SendPlayerEvent(string playerEvent)
        {
            if (!string.IsNullOrEmpty(playerEvent))
            {
                _playerFsm.SendEvent(playerEvent);
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
            if(other.tag == Constants.TagGroundbeforecrossing)
            {
                SendPlayerEvent(PlayerConstants.EventWalk);
            }
            else if(other.tag == Constants.TagCrossing)
            {
                CrossingPlayerEntered = other.gameObject;
                SendPlayerEvent(PlayerConstants.EventHitcrossing);
            }
            else if (other.tag == Constants.TagMiddlepoint)
            {
                SendPlayerEvent(PlayerConstants.EventMiddleofcrossing);
            }
            else if(other.tag == Constants.TagGroundaftercrossing)
            {
                Debug.Log("After the crossing");
            }
            else if(other.tag == Constants.TagExit)
            {
                SceneManager.LoadScene(Constants.SceneShop);
            }

        }
        private void OnTriggerExit(Collider other)
        {
            if (other.tag == Constants.TagGroundbeforecrossing)
            {
                Debug.Log("Leaving from ground before");
            }
            else if (other.tag == Constants.TagCrossing)
            {
                Debug.Log("Leaving crossing");
            }
            else if (other.tag == Constants.TagGroundaftercrossing)
            {
                SendPlayerEvent(PlayerConstants.EventExitcrossing);
            }
        }
    }
}

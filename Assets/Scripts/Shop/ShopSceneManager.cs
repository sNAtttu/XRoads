using Helpers;
using UnityEngine;

namespace Shop
{
    public class ShopSceneManager : MonoBehaviour {
	
    
        void Update () {

            if (Application.isEditor)
            {
                HandleMouseInput();
                HandleKeyboardInput();
            }
            else
            {
                HandleTouchInput();
            }

        }

        private void HandleKeyboardInput()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                GetComponent<PlayMakerFSM>().SendEvent(ShopSceneConstants.EventClearselection);
            }
        }

        private void HandleTouchInput()
        {
            if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began))
            {
                Ray raycast = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
                RaycastHit hit;
                if (Physics.Raycast(raycast, out hit))
                {
                    SendEventToPlayMakerFsm(hit);
                }
            }
        }

        private void HandleMouseInput()
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit = new RaycastHit();
            if (Input.GetMouseButton(0))
            {
                if (Physics.Raycast(ray, out hit))
                {
                    SendEventToPlayMakerFsm(hit);
                }
            }
        }

        private void SendEventToPlayMakerFsm(RaycastHit hit)
        {
            if (hit.collider.tag == ShopSceneConstants.TagBlacksmith)
            {
                GetComponent<PlayMakerFSM>().SendEvent(ShopSceneConstants.EventSelectBlacksmith);
            }
            else if(hit.collider.tag == ShopSceneConstants.TagInn)
            {
                GetComponent<PlayMakerFSM>().SendEvent(ShopSceneConstants.EventSelectInn);
            }
            else if (hit.collider.tag == ShopSceneConstants.TagEnchanter)
            {
                GetComponent<PlayMakerFSM>().SendEvent(ShopSceneConstants.EventSelectEnchanter);
            }
        }
    }
}

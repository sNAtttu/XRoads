using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
            GetComponent<PlayMakerFSM>().SendEvent(ShopSceneConstants.EVENT_CLEARSELECTION);
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
                SendEventToPlayMakerFSM(hit);
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
                SendEventToPlayMakerFSM(hit);
            }
        }
    }

    private void SendEventToPlayMakerFSM(RaycastHit hit)
    {
        if (hit.collider.tag == ShopSceneConstants.TAG_BLACKSMITH)
        {
            GetComponent<PlayMakerFSM>().SendEvent(ShopSceneConstants.EVENT_SELECT_BLACKSMITH);
        }
        else if(hit.collider.tag == ShopSceneConstants.TAG_INN)
        {
            GetComponent<PlayMakerFSM>().SendEvent(ShopSceneConstants.EVENT_SELECT_INN);
        }
        else if (hit.collider.tag == ShopSceneConstants.TAG_ENCHANTER)
        {
            GetComponent<PlayMakerFSM>().SendEvent(ShopSceneConstants.EVENT_SELECT_ENCHANTER);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    public float RunSpeed = 5;
    public float WalkSpeed = 2f;

    private PlayerState playerState;
    private Rigidbody playerBody;
    // Use this for initialization
    void Awake()
    {
        playerBody = GetComponent<Rigidbody>();
        playerState = GetComponent<PlayerState>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(playerState.GetPlayerState() == PlayerConstants.STATE_RUNNING)
        {
            playerBody.velocity = transform.forward * RunSpeed;
        }
        else if(playerState.GetPlayerState() == PlayerConstants.STATE_COMINGTOCROSSING)
        {
            playerBody.velocity = transform.forward * RunSpeed;
        }
        else if(playerState.GetPlayerState() == PlayerConstants.STATE_CROSSINGBOUNDARIES)
        {
            transform.position = Vector3.MoveTowards(transform.position, playerState.CrossingPlayerEntered.GetComponent<Crossing>().GetMiddlePointLocation(), WalkSpeed * Time.fixedDeltaTime);
        }
        else if(playerState.GetPlayerState() == PlayerConstants.STATE_ATCROSSING)
        {
            playerBody.velocity = new Vector3();
        }
        else if(playerState.GetPlayerState() == PlayerConstants.STATE_LEAVINGCROSSING)
        {
            playerBody.velocity = transform.forward * RunSpeed;
        }
    }
}

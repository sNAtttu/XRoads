using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputMessages : MonoBehaviour
{

    public void Rotate(string direction)
    {
        StartCoroutine(ContinuousRotation(direction));
    }

    IEnumerator ContinuousRotation(string direction)
    {
        int degrees = 90;
        int turnDirection = 1;
        if (direction == "backwards")
            degrees = 180;    
        if (direction == "left")
            turnDirection = -1;
        for(var i = 0; i <= degrees; i++)
        {
            transform.Rotate(Vector3.up, turnDirection);
            yield return new WaitForSeconds(0.01f);
        }
    }

}

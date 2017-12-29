using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crossing : MonoBehaviour
{
    public GameObject MiddlePoint;

    public List<Constants.Directions> AllowedDirections;

    public Vector3 GetMiddlePointLocation()
    {
        return MiddlePoint.transform.position;
    }

}

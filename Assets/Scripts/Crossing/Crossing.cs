using System.Collections.Generic;
using Helpers;
using UnityEngine;

namespace Crossing
{
    public class Crossing : MonoBehaviour
    {
        public GameObject MiddlePoint;

        public List<Constants.Directions> AllowedDirections;

        public Vector3 GetMiddlePointLocation()
        {
            return MiddlePoint.transform.position;
        }

    }
}

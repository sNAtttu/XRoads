using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenuCamera : MonoBehaviour
{
    public float RotationAngle = 1f;
    public float WaitForNextRotate = 0.05f;
    private void Start()
    {
        StartCoroutine(ContinuousRotation());
    }

    IEnumerator ContinuousRotation()
    {
        while (true)
        {
            transform.Rotate(Vector3.up, RotationAngle);
            yield return new WaitForSeconds(WaitForNextRotate);
        }
    }
}

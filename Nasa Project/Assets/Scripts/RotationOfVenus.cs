using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationOfVenus : MonoBehaviour
{
    public Transform sun;
    public Transform venus;
    private void FixedUpdate()
    {
        if (StartRelativeVelocity.start == true)
        {
            venus.transform.RotateAround(sun.transform.position, Vector3.up, 3.06f * Time.fixedDeltaTime);
        }
    }
}

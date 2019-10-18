using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationOfAstroid_1 : MonoBehaviour
{
    public Transform earth;
    public Transform astroid;

    private void FixedUpdate()
    {
        if (StartRelativeVelocity.start == true)
        {
            astroid.transform.RotateAround(earth.transform.position, Vector3.up, 10f * Time.fixedDeltaTime);
        }
        
    }
}

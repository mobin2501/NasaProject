using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationOfPlanets : MonoBehaviour
{
    public Transform sun;
    public Transform planet;

    private void FixedUpdate()
    {
        if (StartRelativeVelocity.start == true)
        {
            planet.transform.RotateAround(sun.transform.position, Vector3.up, 1.88f * Time.fixedDeltaTime);
        }
            
    }
}

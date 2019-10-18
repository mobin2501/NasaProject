using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthScript2 : MonoBehaviour
{

    public Transform sun;
    public Transform earth;
    
    private void FixedUpdate()
    {
        float speed = StartRelativeVelocity.speed;
        if (StartRelativeVelocity.start == true)
        {
            earth.transform.RotateAround(sun.transform.position, Vector3.up, 1.88f*speed * Time.fixedDeltaTime);
        }
    }
}

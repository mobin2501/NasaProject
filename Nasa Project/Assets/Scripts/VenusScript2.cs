using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VenusScript2 : MonoBehaviour
{
    public Transform sun;
    public Transform venus;

    private void FixedUpdate()
    {
        float speed = StartRelativeVelocity.speed;
        if (StartRelativeVelocity.start == true)
        {
            venus.transform.RotateAround(sun.transform.position, Vector3.up, 3.05f * speed * Time.fixedDeltaTime);
        }
    }
}

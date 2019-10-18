using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarsScript2 : MonoBehaviour
{
    public Transform sun;
    public Transform mars;

    private void FixedUpdate()
    {
        float speed = StartRelativeVelocity.speed;
        if (StartRelativeVelocity.start == true)
        {
            mars.transform.RotateAround(sun.transform.position, Vector3.up, 1f * speed * Time.fixedDeltaTime);
        }
    }
}

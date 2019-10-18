
using UnityEngine;

public class RotationOfMars : MonoBehaviour
{
    public Transform sun;
    public Transform mars;
    private void FixedUpdate()
    {
        if (StartRelativeVelocity.start == true)
        {
            mars.transform.RotateAround(sun.transform.position, Vector3.up, 1f * Time.fixedDeltaTime);
        }
    }
}

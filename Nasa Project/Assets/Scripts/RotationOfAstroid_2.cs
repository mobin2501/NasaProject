
using UnityEngine;

public class RotationOfAstroid_2 : MonoBehaviour
{
    public Transform sun;
    public Transform astroid;
    private void FixedUpdate()
    {
        if (StartRelativeVelocity.start == true)
        {
            astroid.transform.RotateAround(sun.transform.position, Vector3.up, 1.3f * Time.fixedDeltaTime);
        }
    }
}

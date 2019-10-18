
using UnityEngine;

public class CamScript2 : MonoBehaviour
{
    public Transform cam;
    private void FixedUpdate()
    {
        float rot = StartRelativeVelocity.speed;
        cam.transform.Rotate(0f,(rot)*Time.fixedDeltaTime , 0f);

        if (Input.GetKey(KeyCode.W))
        {
            cam.transform.Rotate(-0.5f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            cam.transform.Rotate(0.5f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            cam.transform.Rotate(0f, -.5f, 0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            cam.transform.Rotate(0f, 0.5f, 0f);
        }
    }
}

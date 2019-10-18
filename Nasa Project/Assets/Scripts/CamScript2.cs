
using UnityEngine;

public class CamScript2 : MonoBehaviour
{
    public Transform cam;
    private void FixedUpdate()
    {
        float rot = StartRelativeVelocity.speed;
        cam.transform.Rotate(0f,(rot)*Time.fixedDeltaTime , 0f);
        
    }
}

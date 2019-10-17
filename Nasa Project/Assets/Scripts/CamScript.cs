
using UnityEngine;

public class CamScript : MonoBehaviour
{
    public Transform ts;
    public Transform campos;
    Vector3 offset = new Vector3(0f, 0f, -10f);
    private void FixedUpdate()
    {
        campos.position = ts.position + offset;
    }
}

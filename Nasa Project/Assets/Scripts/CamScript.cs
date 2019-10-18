
using UnityEngine;

public class CamScript : MonoBehaviour
{
    public Transform ts;
    public Transform campos;
    Vector3 offset = new Vector3(0f, 30f, 0f);
    private void Start()
    {
       // campos.Rotate(0f, 0f, 0f);
    }
    private void FixedUpdate()
    {
        campos.position = ts.position + offset;
        
    }
}

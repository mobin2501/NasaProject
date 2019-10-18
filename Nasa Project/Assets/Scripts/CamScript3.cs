using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamScript3 : MonoBehaviour
{
    public Transform ts;
    public Transform campos;
    public Vector3 offset = new Vector3(0f, 2f, -10f);
    private void Start()
    {
        // campos.Rotate(0f, 0f, 0f);
    }
    private void FixedUpdate()
    {
        campos.position = campos.position;

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TelescopeMovement : MonoBehaviour
{
    public Rigidbody tlscope;
    bool three = false;
    private void Start()
    {
       three = false;
    }


    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            tlscope.AddForce(0f, 1f, 0f,ForceMode.Force);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            tlscope.AddForce(0f, -1f, 0f, ForceMode.Force);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            tlscope.AddForce(-1f, 0f, 0f, ForceMode.Force);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            tlscope.AddForce(1f, 0f, 0f, ForceMode.Force);
        }
        else if (Input.GetKey(KeyCode.Z) && three == true)
        {
            tlscope.AddForce(0f, 0f, 1f, ForceMode.Force);
        }
        else if (Input.GetKey(KeyCode.X)&& three==true)
        {
            tlscope.AddForce(0f, 0f, -1f, ForceMode.Force);
        }
        

    }
}

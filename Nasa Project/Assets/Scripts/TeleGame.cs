using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleGame : MonoBehaviour
{
    public Transform ts;
    public Rigidbody rb;
    public Vector3 w;
    public Vector3 a;
    private void Start()
    {
        ts.transform.position = ts.transform.position;
    }
    private void FixedUpdate()
    {
                if (Input.GetKey(KeyCode.W))
                {
                    ts.transform.position = ts.transform.position + w * Time.fixedDeltaTime;

                }
                else if (Input.GetKey(KeyCode.S))
                {
                    ts.transform.position = ts.transform.position - w * Time.fixedDeltaTime;
                }
                else if (Input.GetKey(KeyCode.A))
                {
                    ts.transform.position = ts.transform.position - a * Time.fixedDeltaTime;
                }
                else if (Input.GetKey(KeyCode.D))
                {
                    ts.transform.position = ts.transform.position + a * Time.fixedDeltaTime;
                }
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("GO");
    }
}

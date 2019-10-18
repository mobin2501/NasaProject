
using UnityEngine;

public class TelescopeMovement : MonoBehaviour
{
    public Transform sun;
    public Transform ts;
    //public float force = 5;
    public float speed;
    public Vector3 w = new Vector3(0f, 0f, .2f);
    public Vector3 a = new Vector3(.2f, 0f, 0f);
    private void FixedUpdate()
    {
        
        if (StartRelativeVelocity.start == true)
        {
            if (StartRelativeVelocity.speed < 90 && StartRelativeVelocity.speed>0)
            {
                speed = StartRelativeVelocity.speed;
            }
            
                ts.transform.RotateAround(sun.transform.position, Vector3.up, speed * Time.fixedDeltaTime);

                
            
            
            
        }
        
           
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("OH no !!! You crashed !");
    }
    
}


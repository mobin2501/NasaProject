using UnityEngine.SceneManagement;
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
                if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
                {
                    ts.transform.position = ts.transform.position + w * Time.fixedDeltaTime;

                }
                else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
                {
                    ts.transform.position = ts.transform.position - w * Time.fixedDeltaTime;
                }
                else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
                {
                    ts.transform.position = ts.transform.position - a * Time.fixedDeltaTime;
                }
                else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
                {
                    ts.transform.position = ts.transform.position + a * Time.fixedDeltaTime;
                }
    }
    private void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene(5);
    }
}

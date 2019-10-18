using UnityEngine.UI;
using UnityEngine;

public class PhoneController : MonoBehaviour
{
    public Button bt;
    public Transform ts;
    public Vector3 w;
    public Vector3 a;
    private void Start()
    {
        bt.onClick.AddListener(A);
    }
    public void A()
    {
        ts.transform.position = ts.transform.position - a * Time.fixedDeltaTime;
    }
}

using UnityEngine.UI;
using UnityEngine;

public class PhoneControllerRight : MonoBehaviour
{
    public Button bt;
    public Transform ts;
    public Vector3 w;
    public Vector3 a;
    private void Start()
    {
        bt.onClick.AddListener(D);
    }
    public void D()
    {
        ts.transform.position = ts.transform.position - a * Time.fixedDeltaTime;
    }
}

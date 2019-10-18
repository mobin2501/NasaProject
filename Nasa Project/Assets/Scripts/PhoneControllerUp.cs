using UnityEngine.UI;
using UnityEngine;

public class PhoneControllerUp : MonoBehaviour
{
    public Button bt;
    public Transform ts;
    public Vector3 w;
    public Vector3 a;
    private void Start()
    {
        bt.onClick.AddListener(W);
    }
    public void W()
    {
        ts.transform.position = ts.transform.position + w * Time.fixedDeltaTime;
    }
}

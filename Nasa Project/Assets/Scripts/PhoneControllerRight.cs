using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine;
using System.Collections;

public class PhoneControllerRight : MonoBehaviour , IPointerDownHandler
{
    public Button bt;
    public Transform ts;
    public Vector3 w;
    public Vector3 a;
    bool down = false;
    /*private void Start()
    {
        bt.onClick.AddListener(D);
    }*/
    
    public void OnPointerDown(PointerEventData eventData)
    {
        D();
    }
    public void D()
    {
        ts.transform.position = ts.transform.position + a * Time.fixedDeltaTime;
    }
}

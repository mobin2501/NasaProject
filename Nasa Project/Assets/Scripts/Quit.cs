using UnityEngine.UI;
using UnityEngine;

public class Quit : MonoBehaviour
{
    public Button bt;
    private void Start()
    {
        bt.onClick.AddListener(Done);
    }
    public void Done()
    {
        Application.Quit();
    }
}

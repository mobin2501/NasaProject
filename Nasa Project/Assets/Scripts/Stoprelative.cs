using UnityEngine.UI;
using UnityEngine;

public class Stoprelative : MonoBehaviour
{
    public Button bt;
    private void Start()
    {
        bt.onClick.AddListener(Stop);
    }
    public void Stop()
    {
        StartRelativeVelocity.start = false;
    }
}

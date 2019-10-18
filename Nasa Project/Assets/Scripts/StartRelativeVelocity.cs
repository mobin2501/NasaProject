using UnityEngine.UI;
using UnityEngine;

public class StartRelativeVelocity : MonoBehaviour
{
    public Button bt;
    public InputField inf;
    public static bool start = true;
    public static int speed ;
    private void Start()
    {
        bt.onClick.AddListener(RelativeStart);
    }
    public void RelativeStart()
    {
        string str = inf.text;
        Debug.Log(str);
        if (str == null)
        {
            speed = 0;
        }
        speed = int.Parse(str);
        Debug.Log(speed);
        start = true;
    }
}

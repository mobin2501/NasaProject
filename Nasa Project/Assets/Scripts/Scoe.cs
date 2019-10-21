using UnityEngine.UI;
using UnityEngine;

public class Scoe : MonoBehaviour
{
    public Text scoretext;
    public static int score;
    private void Start()
    {
        score = 0;
        scoretext.text = score.ToString();
    }
    private void FixedUpdate()
    {
        scoretext.text = score.ToString();
    }
}

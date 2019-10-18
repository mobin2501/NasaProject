using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Game : MonoBehaviour
{
    public Button bt;
    private void Start()
    {
        bt.onClick.AddListener(GameLoad);
    }
    public void GameLoad()
    {
        SceneManager.LoadScene(1);
    }
}

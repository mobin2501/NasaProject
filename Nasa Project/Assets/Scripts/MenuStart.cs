using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class MenuStart: MonoBehaviour
{
    public Button strt;
    private void Start()
    {
        strt.onClick.AddListener(MenStart);
    }
    void MenStart()
    {
        SceneManager.LoadScene(1);
    }
}

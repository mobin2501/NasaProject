using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class LoadTeleOrbit : MonoBehaviour
{
    public Button bt;
    private void Start()
    {
        bt.onClick.AddListener(Scene);
    }
    public void Scene()
    {
        SceneManager.LoadScene(2);
    }
}

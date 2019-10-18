using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadSolarOrbit : MonoBehaviour
{
    public Button bt;
    private void Start()
    {
        bt.onClick.AddListener(Scene);
    }
    public void Scene()
    {
        SceneManager.LoadScene(4);
    }
}

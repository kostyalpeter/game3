using UnityEngine;
using UnityEngine.SceneManagement;

public class SkinScene : MonoBehaviour
{
    public void LoadScene()
    {
        SceneManager.LoadScene("Skins");
        Time.timeScale = 1f;
    }
}

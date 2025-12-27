using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    public void LoadScene()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1f;
    }
}

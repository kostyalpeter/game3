using UnityEngine;
using UnityEngine.SceneManagement;

public class Maps : MonoBehaviour
{
    public void LoadScene()
    {
        if (Levels.Level == 1)
        {
            SceneManager.LoadScene("Easy");
            Time.timeScale = 1f;
        }

        else if (Levels.Level == 2)
        {
            SceneManager.LoadScene("Medium");
            Time.timeScale = 1f;
        }
        else if (Levels.Level == 3)
        {
            SceneManager.LoadScene("hard");
            Time.timeScale = 1f;
        }
    }
}

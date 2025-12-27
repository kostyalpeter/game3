using UnityEngine;
using UnityEngine.SceneManagement;

public class Maps : MonoBehaviour
{
    public void LoadScene()
    {
        if (Levels.Level == 1 && SkinChoose.Face != 0 && SkinChoose.Inside != 0 && SkinChoose.Frame != 0 || SkinChoose.Skin != 0)
        {
            SceneManager.LoadScene("Easy");
            Time.timeScale = 1f;
        }

        else if (Levels.Level == 2 && SkinChoose.Face != 0 && SkinChoose.Inside != 0 && SkinChoose.Frame != 0 || SkinChoose.Skin != 0)
        {
            SceneManager.LoadScene("Medium");
            Time.timeScale = 1f;
        }
        else if (Levels.Level == 3 && SkinChoose.Face != 0 && SkinChoose.Inside != 0 && SkinChoose.Frame != 0 || SkinChoose.Skin != 0)
        {
            SceneManager.LoadScene("hard");
            Time.timeScale = 1f;
        }
    }
}

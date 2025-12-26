using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelsScene : MonoBehaviour
{
    public void LoadScene()
    {
        SceneManager.LoadScene("Levels");
    }
}

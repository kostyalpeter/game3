using UnityEngine;

public class Die : MonoBehaviour
{
    public string killTag = "KillZone";
    public GameObject DieText;
    public GameObject Restart;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && CompareTag("KillZone"))
        {
            Restart.SetActive(true);
            DieText.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}

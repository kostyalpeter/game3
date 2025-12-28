using UnityEngine;

public class Die : MonoBehaviour
{
    public string killTag = "KillZone";
    public GameObject DieText;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && CompareTag("KillZone"))
        {
            Time.timeScale = 0f;
            DieText.SetActive(true);
        }
    }
}

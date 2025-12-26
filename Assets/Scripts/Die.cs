using UnityEngine;

public class Die : MonoBehaviour
{
    public string killTag = "KillZone";

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && CompareTag("KillZone"))
        {
            Time.timeScale = 0f;
        }
    }
}

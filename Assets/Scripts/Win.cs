using UnityEngine;

public class Win : MonoBehaviour
{
    public GameObject WinText;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Time.timeScale = 0f;
            WinText.SetActive(true);
        }
    }
}

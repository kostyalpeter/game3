using UnityEngine;

public class Trap : MonoBehaviour
{
    public GameObject trap;
void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            trap.SetActive(false);
        }
    }
}

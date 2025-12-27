using UnityEngine;

public class Activater : MonoBehaviour
{
    public GameObject trap;
void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            trap.transform.localPosition = new Vector3(trap.transform.localPosition.x, 0.1f, trap.transform.localPosition.z);
        }
    }
}

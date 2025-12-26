using UnityEngine;

public class JumpPad : MonoBehaviour
{
    public GameObject JumperUp;
    public GameObject JumperDown;
    public float JumpForce = 10f;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, JumpForce);
            JumperActivation();
        }
    }
    void JumperActivation()
    {
        JumperDown.SetActive(true);
        JumperUp.SetActive(false);
    }
}


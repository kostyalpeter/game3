using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Move : MonoBehaviour
{
    [SerializeField] private float velocity = 5f;
    private Rigidbody2D rb;
    public int OnGround;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {

        if (Mouse.current.leftButton.isPressed && OnGround == 1)
        {
            Jump();
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)

    {
        OnGround = 1;
    }
    public void OnCollisionExit2D(Collision2D collision)

    {
        OnGround = 0;
    }
    public void Jump()
    {
        rb.linearVelocity = Vector2.up * velocity;
    }
}

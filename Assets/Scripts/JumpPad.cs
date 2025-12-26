using UnityEngine;

public class JumpPad : MonoBehaviour
{
    public string JumpTag = "JumpPad";
    Move move;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && CompareTag("JumpPad"))
        {
            move.Jump();
        }
    }
}

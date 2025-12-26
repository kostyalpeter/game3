using UnityEngine;

public class MoveObjects : MonoBehaviour
{
    [SerializeField] private float speed = 4f;

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}

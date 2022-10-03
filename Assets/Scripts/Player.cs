using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 15f;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal") * Time.fixedDeltaTime * speed;

        rb.MovePosition(rb.position + Vector2.right * x);

    }
}

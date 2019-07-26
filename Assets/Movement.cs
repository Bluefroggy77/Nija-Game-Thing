using UnityEngine;

public class Movement : MonoBehaviour
{
    public bool InAir;
    public float Speed;
    public float AirSpeed;
    public float JumpForce;
    Rigidbody2D rb;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();       
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-Speed, rb.velocity.y);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(Speed, rb.velocity.y);
        }
        if (!Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(rb.velocity.x/1.35f, rb.velocity.y);
        }
    }
}

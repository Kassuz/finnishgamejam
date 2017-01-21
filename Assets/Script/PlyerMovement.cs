using UnityEngine;
using System.Collections;

public class PlyerMovement : MonoBehaviour
{
    [SerializeField] private float jumpSpeed;
    [SerializeField] private float speed;

    private Rigidbody2D rb2d;
    private SpriteRenderer sprite;

    private float horizontalInput;
    private bool hasJumped;
    private bool facingLeft = true;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        sprite = GetComponentInChildren<SpriteRenderer>();
    }

    private void Update()
    {
        if (Input.GetButton("Jump"))
        {
            hasJumped = true;
        }

        horizontalInput = Input.GetAxis("Horizontal");

        if (horizontalInput > 0.1 && facingLeft)
        {
            Flip();
        }
        else if (horizontalInput < -0.1 && !facingLeft)
        {
            Flip();
        }
    }

    private void FixedUpdate()
    {
        if (hasJumped)
        {
            hasJumped = false;
            rb2d.velocity = new Vector2(rb2d.velocity.x, jumpSpeed);
        }

        rb2d.velocity = new Vector2(horizontalInput * speed, rb2d.velocity.y);
    }

    private void Flip()
    {
        sprite.flipX = !sprite.flipX;
        facingLeft = !facingLeft;
    }
}

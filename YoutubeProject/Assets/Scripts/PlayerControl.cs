using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 10f;
    public float jumpSpeed = 5f;
    public float movement = 0;
    public Rigidbody2D rigidbody2d;
    public Transform groundCheckPoint;
    public float groundCheckRadius;
    public LayerMask groundLayer;
    private bool isTouchingGround;
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        isTouchingGround = Physics2D.OverlapCircle(groundCheckPoint.position, groundCheckRadius, groundLayer);
        movement = Input.GetAxis("Horizontal");
        if (movement < 0)
        {
            rigidbody2d.velocity = new Vector2(movement * speed, rigidbody2d.velocity.y);
        }
        else if (movement > 0)
        {
            rigidbody2d.velocity = new Vector2(movement * speed, rigidbody2d.velocity.y);
        }
        else
        {
            rigidbody2d.velocity = new Vector2(0, rigidbody2d.velocity.y);
        }
        if (Input.GetButtonDown("Jump") && isTouchingGround)
        {
            rigidbody2d.velocity = new Vector2(rigidbody2d.velocity.x,jumpSpeed);
        }

    }
}

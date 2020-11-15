using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 10f;
    public float movement = 0;
    public Rigidbody2D rigidbody2d;
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
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
    
    
    }
}

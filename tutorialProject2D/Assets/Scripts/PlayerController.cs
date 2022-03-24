using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;

    float xInput;
    public float speed;
    public float jumpForce;
    bool isGrounded;
    public Transform groundCheck;
    public LayerMask groundLayer;
    Animator anim;

    bool doubleJump = true;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        xInput = Input.GetAxisRaw("Horizontal");

        rb.velocity = new Vector2(xInput * speed, rb.velocity.y);

        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.1f,groundLayer);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            if (isGrounded)
            {
                Jump();
            }

            else
            {
                if (doubleJump)
                {
                    Jump(true);
                    doubleJump = false;
                }
            }
        }
        if(isGrounded)
        {
            doubleJump = true;
        }
        anim.SetBool("isGrounded", isGrounded);
        anim.SetFloat("speed", Mathf.Abs(rb.velocity.x));

        faceDirection();
    }

    void faceDirection()
    {
        if (rb.velocity.x < 0)
        {
            GetComponent<SpriteRenderer>().flipX = true;

        }
        else if(rb.velocity.x > 0)
        {
            GetComponent<SpriteRenderer>().flipX = false;

        }
        

    }

    void Jump(bool isDblJump = false)
    {
        if (!isDblJump)
        { rb.velocity = new Vector2(rb.velocity.x, jumpForce);
 }
        else
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce * 0.5f);
        }
    }
}

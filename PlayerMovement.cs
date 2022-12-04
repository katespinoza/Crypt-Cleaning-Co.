using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float walkspeed, jumpVelocity, jumpWaitTime;
    public Rigidbody2D rb;
    public KeyCode jumpKey, jumpKey2, jumpKey3;
    public LayerMask ground;
    public Collider2D footCollider;

    private float jumpWaitTimer;
    private bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        float direction = Input.GetAxisRaw("Horizontal");
        isGrounded = footCollider.IsTouchingLayers(ground);

        rb.velocity = new Vector2(walkspeed * direction * Time.fixedDeltaTime, rb.velocity.y);

        if (direction != 0f)
        {
            transform.localScale = new Vector2(Mathf.Abs(transform.localScale.x) * direction, transform.localScale.y);
        }

        if(Input.GetKeyDown(jumpKey) || Input.GetKeyDown(jumpKey2) || Input.GetKeyDown(jumpKey3))
        {
            if (isGrounded || jumpWaitTimer > 0)
            {
                Jump();
            }
        }

        //Timer
        if (isGrounded)
        {
            jumpWaitTimer = jumpWaitTime;
        }
        else
        {
            if(jumpWaitTimer > 0f)
            {
                jumpWaitTimer -= Time.deltaTime;
            }
        }
    }

    void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpVelocity * Time.fixedDeltaTime);
    }

}

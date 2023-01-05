using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb2D;
    Animator a;
    private SpriteRenderer sr;

    private float moveSpeed;
    private float jumpForce;
    private bool isJumping;
    private float moveHorizontal;
    private float moveVertical;

    
    // Start is called before the first frame update
    void Start()
    {
        a = gameObject.GetComponent<Animator>();
        rb2D = gameObject.GetComponent<Rigidbody2D>();
        sr = gameObject.GetComponent<SpriteRenderer>();

        moveSpeed = 1.5f;
        jumpForce = 60f;
        isJumping = false;
    }

    // Update is called once per frame
    void Update()
    {
        moveHorizontal = Input.GetAxisRaw("Horizontal");
        moveVertical = Input.GetAxisRaw("Vertical");

        if(moveHorizontal < 0)
        {
            sr.flipX = true;
        }
        else
        {
            sr.flipX = false;
        }

        if(moveHorizontal == 0)
        {
            a.SetBool("Moving", false);
        }
        else
        {
            a.SetBool("Moving", true);
        }
    }

    private void FixedUpdate()
    {
        if (moveHorizontal > 0.1f || moveHorizontal < -0.1f)
        {
            rb2D.AddForce(new Vector2(moveHorizontal * moveSpeed, 0f), ForceMode2D.Impulse);
        }

        if (!isJumping && moveVertical > 0.1f)
        {
            rb2D.AddForce(new Vector2(0f, moveVertical * jumpForce), ForceMode2D.Impulse);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isJumping = false;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isJumping = true;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideMove : MonoBehaviour
{

    public float accel = 15;
    private Rigidbody2D rb2;
    private SpriteRenderer sr;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        float horizontalValue = Input.GetAxis("Horizontal");
        float veritcalValue = Input.GetAxis("Vertical");

        if (horizontalValue == 0)
        {
            anim.SetBool("Moving", false);
        }
        else
        {
            anim.SetBool("Moving", true);
        }
    }
    private void FixedUpdate()
    {

        //Move Right
        if (Input.GetAxis("Horizontal") > 0)
        {
            sr.flipX = false;
            rb2.AddForce(new Vector2(accel, 0));
        }

        //Move Left
        if (Input.GetAxis("Horizontal") < 0)
        {
            sr.flipX = true;
            rb2.AddForce(new Vector2(-accel, 0));
        }


    }
}

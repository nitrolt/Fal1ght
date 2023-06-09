using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BetterJump : MonoBehaviour
{
    public float fallMult = 2.5f;
    public float lowJumpFallMult = 2f;

    private Rigidbody2D rb;


    void Start()
    {
        rb = GetComponent<Rigidbody2D> ();    
    }

    void Update()
    {
        if(rb.velocity.y < 0)
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (fallMult - 1) * Time.deltaTime;
        }
        else if(rb.velocity.y > 0 && !Input.GetKey(KeyCode.W))
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpFallMult - 1) * Time.deltaTime;
        }
    }
}

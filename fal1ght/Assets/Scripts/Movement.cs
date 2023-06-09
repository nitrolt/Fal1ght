using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Collision coll;
    private Rigidbody2D rb;

    [Header("Stats")]
    public float speed;
    public float jumpForce;
    public float slideSpeed;
    public float wallJumpLerp;
    public float dashSpeed;

    [Header("Boolean")]
    public bool canMove;
    public bool wallGrab;
    public bool wallJumped;
    public bool wallSlide;
    public bool isDashing;

    [Space]

    private bool isGrounded;
    private bool hasDashed;

    public int side = 1;



    // Start is called before the first frame update
    void Start()
    {
        coll = GetComponent<Collision>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    void Flip(int side)
    {
        Vector3 Scaler = transform.localScale;
        Scaler.x = side;
        transform.localScale = Scaler;
    }
}

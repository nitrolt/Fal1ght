using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    [Header("Layer")]

    public LayerMask groundLayer;

    [Header("Check")]

    public bool onGround;
    public bool onWall;
    public bool onRightWall;
    public bool onLeftWall;

    [Space]

    public int wallSide;

    [Header("Collision")]

    public float collRadius = 0.25f;
    public Vector2 leftOffset, rightOffset, botOffset;
    public Vector2 botCheckRadius = new Vector2 (0, 0);
    private Color debugCollisionColor = Color.red;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        onLeftWall = Physics2D.OverlapCircle((Vector2)transform.position + leftOffset, collRadius, groundLayer);
        onRightWall = Physics2D.OverlapCircle((Vector2)transform.position +  rightOffset, collRadius, groundLayer);
        onWall = (onRightWall || onLeftWall);

        wallSide = onRightWall ? -1 : 1;

        onGround = Physics2D.OverlapBox((Vector2)transform.position + botOffset, botCheckRadius, 0, groundLayer);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;

        Gizmos.DrawWireSphere((Vector2)transform.position + rightOffset, collRadius);
        Gizmos.DrawWireSphere((Vector2)transform.position + leftOffset, collRadius);
        Gizmos.DrawWireCube((Vector2)transform.position + botOffset, botCheckRadius);
    }
}

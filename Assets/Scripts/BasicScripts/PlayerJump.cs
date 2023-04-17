using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [SerializeField]
    private KeyCode jumpButton;
    [SerializeField]
    private Rigidbody2D rb;
    [SerializeField]
    private Animator playerAnimator;

    [SerializeField]
    private Transform groundCheck;
    [SerializeField]
    private LayerMask groundLayer;

    [SerializeField]
    private bool canJumpMidAir;
    
    [SerializeField]
    private int jumpPower;

    // Update is called once per frame
    void Update()
    {

         if (Input.GetKeyDown(jumpButton) && isGrounded())
         {
            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
            playerAnimator.SetTrigger("Jump");
        }
         if (rb.velocity.y != 0)
         {
            playerAnimator.SetBool("IsJumping", true);
        }
         else
         {
            playerAnimator.SetBool("IsJumping", false);
         }
    }

    public bool isGrounded()
    {
        return Physics2D.OverlapCapsule(groundCheck.position, new Vector2(0.1f, 0.1F), CapsuleDirection2D.Horizontal, 0, groundLayer);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicPlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float speed = 1;
    [SerializeField]
    private float standartSpeed = 1;
    [SerializeField]
    private Rigidbody2D rb;
    [SerializeField]
    private Animator playerAnimator;

    [SerializeField]
    private GameObject reaper;

    private float movement;
    private bool isFacingRight = true;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameObject.GetComponent<PlayerSlide>().getIsSliding())
        {
            movement = Input.GetAxis("Horizontal");
        }

        if (reaper.activeSelf)
        {
            movement = 0;
        }
        
        if (movement != 0 && !gameObject.GetComponent<PlayerSlide>().getIsSliding() && rb.velocity.y ==0)
        {
            playerAnimator.SetBool("IsWalking", true);
        }
        else
        {
            playerAnimator.SetBool("IsWalking", false);
        }

        
        Flip();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(movement * speed, rb.velocity.y);
    }

    private void Flip()
    {
        if (isFacingRight && movement < 0f || !isFacingRight && movement > 0f)
        {
            isFacingRight = !isFacingRight;
            transform.Rotate(0f, 180f, 0f);
        }
    }

    public void setSpeed(float value)
    {
        speed = value;
    }

    public void setStandartSpeed()
    {
        speed = standartSpeed;
    }

    public void roundUpMovement()
    {
        if(movement > 0)
        {
            movement = 1;
        }
        if (movement < 0)
        {
            movement = -1;
        }
    }

    public float getMovement()
    {
        return movement;
    }

    public float getSpeed()
    {
        return speed;
    }
}

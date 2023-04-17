using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float jump;
    [SerializeField] private float Move;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private SpriteRenderer spritePicture;
    [SerializeField] private Sprite[] positions;
    [SerializeField] private Sprite[] walkingPositions;

    public BoxCollider2D colliderOnOff;
    
    private bool Falling = false;
    private bool end = false;
    private bool isFacingRight = true;
    private bool isWalking;
    private bool startedWalking;
    // Start is called before the first frame update
    void Start()
    {
        startedWalking = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        Move = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(speed * Move, rb.velocity.y);
        if(end == false)
        {
            isWalking = false;
            startedWalking = false;
            if (rb.velocity.y < -0.1)
            {
                Falling = true;
                
            }
            else
            {
                Falling = false;
                
            }
            if (Falling)
            {
                setActive();
            }
            else
            {
                setInActive();
            }

            if(rb.velocity.y == 0)
            {
                spritePicture.sprite = positions[0];
            }
            if(rb.velocity.y < -0.1)
            {
                spritePicture.sprite = positions[1];
            }
            if (rb.velocity.y > 0.1)
            {
                spritePicture.sprite = positions[2];
            }
        }
        else
        {
            if (Move == 0)
            {
                isWalking = false;
                startedWalking = false;
                spritePicture.sprite = walkingPositions[0];
            }
            else
            {
                isWalking = true;
                if(isWalking && !startedWalking)
                {
                    StartCoroutine(walkingAnim(0));
                    startedWalking = true;
                }
            }   
        }

        FlipJumping();

    }
    private void OnCollisionEnter2D(Collision2D collision)
    { 

        if(collision.gameObject.CompareTag("EndFloor") == false && (collision.gameObject.CompareTag("Floor") == true || collision.gameObject.CompareTag("Platform")))
        {
            rb.AddForce(new Vector2(rb.velocity.x, jump));
        }

        if(collision.gameObject.CompareTag("colideLeft") || collision.gameObject.CompareTag("colideRight"))
        {
            setInActive();
        }

        if (collision.gameObject.CompareTag("EndFloor") == true)
        {
            end = true;
            
        }
        
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("colideLeft") || collision.gameObject.CompareTag("colideRight"))
        {
            setActive();
        }
    }

    void setInActive()
    {
        colliderOnOff.enabled = false;
    }

    void setActive()
    {
        colliderOnOff.enabled = true;
    }


    private void FlipJumping()
    {
        if (isFacingRight && Move < 0f || !isFacingRight && Move > 0f)
        {
            isFacingRight = !isFacingRight;
            transform.Rotate(0f, 180f, 0f);
        }
    }

    private IEnumerator walkingAnim(int i)
    {
        spritePicture.sprite = walkingPositions[i];
        i++;
        if(i == 3)
        {
            i = 0;
        }
        yield return new WaitForSeconds(1 / 3);
        if(isWalking)
        {
            StartCoroutine(walkingAnim(i));
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSlide : MonoBehaviour
{
    [SerializeField]
    private KeyCode slideButton;
    [SerializeField]
    private float slideSpeed;
    [SerializeField]
    private float slideTime;
    [SerializeField]
    private Animator playerAnimator;
    [SerializeField]
    private CapsuleCollider2D walkingCollider;
    [SerializeField]
    private CapsuleCollider2D slideCollider;
    

    private bool isSliding;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(slideButton) && gameObject.GetComponent<PlayerJump>().isGrounded())
        {
            gameObject.GetComponent<BasicPlayerMovement>().setSpeed(slideSpeed);
            isSliding = true;
            walkingCollider.enabled = false;
            slideCollider.enabled = true;
            playerAnimator.SetBool("IsSliding", true);
            playerAnimator.SetBool("IsJumping", false);
            gameObject.GetComponent<BasicPlayerMovement>().roundUpMovement();
            StartCoroutine(slideCancel());
        }
    }

    private IEnumerator slideCancel()
    {
        yield return new WaitForSeconds(slideTime);
        gameObject.GetComponent<BasicPlayerMovement>().setStandartSpeed();
        walkingCollider.enabled = true;
        slideCollider.enabled = false;
        isSliding = false;
        playerAnimator.SetBool("IsSliding", false);
    }

    public bool getIsSliding()
    {
        return isSliding;
    }
}

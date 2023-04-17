using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeatherClimbing : MonoBehaviour
{
    [SerializeField]
    private GameObject player;
    [SerializeField]
    private Transform bottom;
    [SerializeField]
    private Transform topPosition;
    [SerializeField]
    private bool isStaying;
    [SerializeField]
    private bool isClimbing;
    [SerializeField]
    private float climbingSpeed;

    private void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    void Update()
    {
        if(isStaying && Input.GetKeyDown(KeyCode.W))
        {
            isClimbing = true;
            player.GetComponent<Rigidbody2D>().gravityScale = 0;
        }

        if (player.transform.position == topPosition.position)
        {
           
        }
    }

    private void FixedUpdate()
    {
        if (isClimbing)
        {
            //player.transform.position = Vector2.MoveTowards(player.transform.position, topPosition. position, Time.fixedDeltaTime * climbingSpeed);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject == player)
        {
            isStaying = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject == player)
        {
            isStaying = false;
            isClimbing = false;
            player.GetComponent<Rigidbody2D>().gravityScale = 1;
        }

        if (collision.CompareTag("destructibleBox"))
        {
            collision.GetComponent<DestructibleBox>().getDestroyed();
        }
    }

}
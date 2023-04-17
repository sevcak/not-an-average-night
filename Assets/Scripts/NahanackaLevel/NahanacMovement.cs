using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NahanacMovement : MonoBehaviour
{
    [SerializeField]
    private float travelSpeed;
    [SerializeField]
    private Rigidbody2D rb;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void FixedUpdate()
    {
        rb.velocity = transform.right * travelSpeed;
    }

    public void speedIncrease(float value)
    {
        travelSpeed += value;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("destructibleBox"))
        {
            Debug.Log("hit");
            collision.collider.GetComponent<DestructibleBox>().getDestroyed();
        }
    }

}

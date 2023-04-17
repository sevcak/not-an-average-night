using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebBullet : MonoBehaviour
{
    private Vector2 startPosition;
    [SerializeField]
    private float flightSpeed;
    [SerializeField]
    private float range;
    [SerializeField]
    private Rigidbody2D rb;


    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        rangeReached();
        //Debug.Log(Vector2.Distance(transform.position, startPosition));
    }
    private void FixedUpdate()
    {

        rb.velocity = -transform.up * flightSpeed;
        

    }

    private void rangeReached()
    {
        if (Vector2.Distance(transform.position, startPosition) > range)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(this.gameObject);
    }

}

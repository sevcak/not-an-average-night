using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoyebleBoxMovement : MonoBehaviour
{
    [SerializeField]
    private GameObject[] waypoints;
    [SerializeField]
    private int waypointIndex;
    [SerializeField]
    private float maxSpeed;
    [SerializeField]
    private float minSpeed;
    [SerializeField]
    private float speed;
    // Start is called before the first frame update
    void Start()
    {
        waypointIndex = Random.Range(0, 2);
        //transform.position = new Vector2(Random.Range(waypoints[0].transform.position.x, waypoints[0].transform.position.y), transform.position.y);
        speed = Random.Range(minSpeed,maxSpeed);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        move();
    }

    private void move()
    {

        transform.position = Vector2.MoveTowards(transform.position, waypoints[waypointIndex].transform.position, speed * Time.fixedDeltaTime);
        if (transform.position == waypoints[waypointIndex].transform.position)
        {
            waypointIndex++;
        }
        if (waypointIndex == waypoints.Length)
        {
            waypointIndex = 0;
        }

    }
}

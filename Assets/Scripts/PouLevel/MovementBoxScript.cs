using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBoxScript : MonoBehaviour
{
    [SerializeField]
    private Transform[] waypoints;

    [SerializeField]
    private float speed;
    [SerializeField]

    private int waypointIndex = 0;


    // Start is called before the first frame update
    void Start()
    {
        transform.position = waypoints[waypointIndex].position;
    }

    void FixedUpdate()
    {
        move();
    }

    
    // Update is called once per frame

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

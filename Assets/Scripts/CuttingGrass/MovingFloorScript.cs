using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingFloorScript : MonoBehaviour
{
    [SerializeField] private Transform player;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(player.position.x, transform.position.y);
    }
}

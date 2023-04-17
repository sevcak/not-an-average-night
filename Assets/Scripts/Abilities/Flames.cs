using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flames : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.CompareTag("destructibleBox"))
        {
            collision.GetComponent<DestructibleBox>().getDestroyed();
        }
    }
}

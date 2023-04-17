using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("SpiderWeb"))
        {
            Debug.Log("stituje");
            Destroy(collision.gameObject);
        }
    }
}

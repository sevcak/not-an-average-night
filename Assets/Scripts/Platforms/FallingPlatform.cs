using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
    [SerializeField]
    private float fallDelay = 1f;
    [SerializeField]
    private float destroyDelay = 1f;
    [SerializeField]
    private Rigidbody2D platform;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(Fall());
        }

        if (collision.gameObject.CompareTag("Soul"))
        {
            Destroy(gameObject);
        }
    }

    private IEnumerator Fall()
    {
        yield return new WaitForSeconds(fallDelay);
        platform.bodyType = RigidbodyType2D.Dynamic;
        Destroy(gameObject, destroyDelay);
    }
}

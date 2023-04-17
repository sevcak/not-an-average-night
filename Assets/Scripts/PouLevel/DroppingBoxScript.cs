using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroppingBoxScript : MonoBehaviour
{
    [SerializeField]
    private float fallDelay = 1f;
    [SerializeField]
    private float destroyDelay = 1f;
    [SerializeField]
    private Rigidbody2D platform;
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(Fall());
        }

    }

    private IEnumerator Fall()
    {
        yield return new WaitForSeconds(fallDelay);
        platform.bodyType = RigidbodyType2D.Dynamic;
        Destroy(gameObject, destroyDelay);
    }
}

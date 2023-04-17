using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour
{
    [SerializeField]
    private bool isStanding = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && isStanding)
        {
            Debug.Log("Dovi");
            Application.Quit();
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isStanding = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isStanding = false;
        }
    }
}

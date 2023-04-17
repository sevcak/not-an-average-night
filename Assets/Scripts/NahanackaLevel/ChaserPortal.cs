using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaserPortal : MonoBehaviour
{
    [SerializeField]
    private GameObject chaser;
    [SerializeField]
    private Transform nextPortalPosition;
    void Start()
    {
        //chaser = GameObject.FindGameObjectWithTag("Chaser");
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.CompareTag("Chaser"))
        {
            collision.transform.position = nextPortalPosition.position;
        }
    }
}

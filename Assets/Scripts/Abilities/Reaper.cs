using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reaper : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("grass"))
        {
            //Debug.Log("kosi");
            collision.GetComponent<DestroyGrassScript>().cutGrass();
        }
    }
}

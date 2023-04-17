using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructibleBox : MonoBehaviour
{
    [SerializeField]
    private GameObject breakedBox;


    public void getDestroyed()
    {
        Instantiate(breakedBox, transform.position, transform.rotation);
        Destroy(this.gameObject);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField]
    private GameObject bullet;
    [SerializeField]
    private Transform shootPoint;
    [SerializeField]
    private float shootDelay = 3f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Shoot());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator Shoot()
    {
        yield return new WaitForSeconds(shootDelay);
        Instantiate(bullet, shootPoint.position, shootPoint.rotation);
        StartCoroutine(Shoot());
    }
}

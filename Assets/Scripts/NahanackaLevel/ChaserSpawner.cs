using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaserSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject chaser;
    [SerializeField]
    private float xSuradnica;
    [SerializeField]
    private float ySuradnica;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(chaserSpawn());
    }

    private IEnumerator chaserSpawn()
    {
        Instantiate(chaser, new Vector2(xSuradnica, ySuradnica), transform.rotation);
        yield return new WaitForSeconds(3f);
        StartCoroutine(chaserSpawn());
    }
}

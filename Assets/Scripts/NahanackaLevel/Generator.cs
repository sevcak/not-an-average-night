using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    [SerializeField]
    private GameObject tier;
    [SerializeField]
    private GameObject portal;
    [SerializeField]
    private GameObject finalTier;
    [SerializeField]
    private GameObject standartBox;
    [SerializeField]
    private int numberOfTiers;
    [SerializeField]
    private int highestPoint;
    [SerializeField]
    private int lowestPoint;
    [SerializeField]
    private int highestPointFinal;
    [SerializeField]
    private int lowestPointFinal;
    [SerializeField]
    private int highestPointBox;
    [SerializeField]
    private int lowestPointBox;


    void Start()
    {
        Instantiate(portal, new Vector3(8.5f, -8, 0), transform.rotation);
        for (int i = 0; i < numberOfTiers; i++)
        {
            Instantiate(tier, new Vector3(Random.Range(lowestPoint, highestPoint), 6.5f + i * 6, 0), transform.rotation);
            Instantiate(portal, new Vector3(8.5f, -2 + i * 6, 0), transform.rotation);
            spawnRandomBox(i);
        }
        Instantiate(finalTier, new Vector3(Random.Range(lowestPointFinal, highestPointFinal), 6.5f + numberOfTiers * 6, 0), transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void spawnRandomBox(int value)
    {
        if (1 == Random.Range(0,2)) {
            Instantiate(standartBox, new Vector3(0, -2.7f + value * 6, 0), transform.rotation);
        }
        else
        {
            Instantiate(standartBox, new Vector3(0, -1 + value * 6, 0), transform.rotation);
        }
    }
}

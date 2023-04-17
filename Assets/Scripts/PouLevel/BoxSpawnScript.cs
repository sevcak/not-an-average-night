using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSpawnScript : MonoBehaviour
{
    [SerializeField] private GameObject[] box;
    [SerializeField] private int numberOfBoxes;
    [SerializeField] private GameObject LastPlatform;

    public float heightOffset = 30;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numberOfBoxes; i++) 
        {
            spawnBox(i * 5);
            
        }
        spawnEnd(numberOfBoxes * 5);
        
    }

    // Update is called once per frame


    void spawnBox(float positionY)
    {
        
        float lowestPoint = transform.position.x - heightOffset;
        float highestPoint = transform.position.x + heightOffset;

        Instantiate(box[Random.Range(0, box.Length)], new Vector3(Random.Range(lowestPoint, highestPoint), transform.position.y + positionY, 0), transform.rotation);
    }
    void spawnEnd(float positionY)
    {

        float lowestPoint = transform.position.x - heightOffset;
        float highestPoint = transform.position.x + heightOffset;

        Instantiate(LastPlatform, new Vector3(Random.Range(lowestPoint, highestPoint), transform.position.y + positionY, 0), transform.rotation);
    }
}

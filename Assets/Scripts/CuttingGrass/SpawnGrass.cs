using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGrass : MonoBehaviour
{
    [SerializeField] private Transform parent;
    [SerializeField] private GameObject grass;
    [SerializeField] private int numberOfGrassFields;
    [SerializeField] private float offset;
    [SerializeField] private float offsetGrass;
    [SerializeField] private float off;
    [SerializeField] private float finalOff;
    [SerializeField] private int minGrass;
    [SerializeField] private int maxGrass;
    [SerializeField] private int totalGrass;
    [SerializeField] private GameObject player;
    [SerializeField] private int numberOfGrass;
    [SerializeField] private int objNumber;
    
    void Start()
    {

        player = GameObject.FindGameObjectWithTag("Player");
        

        
        for (int i = 0; i < numberOfGrassFields; i++)
        {
            numberOfGrass = Random.Range(minGrass, maxGrass);
            int j = 0;
            
            while(j < numberOfGrass)
            {
                spawnGrass(j * offset, finalOff);
                j++;
                off = j * offset;
            }

            finalOff = finalOff + (off * 2) + offsetGrass;
            totalGrass = totalGrass + numberOfGrass;
            if (totalGrass < 20 && (numberOfGrassFields - i) == 1)
            {
                numberOfGrassFields = numberOfGrassFields + 1;
            }
        }
     
    }

    void Update()
    {
        objNumber = GameObject.FindGameObjectsWithTag("grass").Length;
        
        if (objNumber < 25)
        {
            
            numberOfGrass = Random.Range(minGrass, maxGrass);

            
            off = Random.Range(-25f, 25f);
            
            
            int j = 0;

            while (j < numberOfGrass)
            {
                
                if(player.transform.position.x > -100 && player.transform.position.x < 110)
                {
                    //Debug.Log(player.transform.position.x);
                    spawnGrass(j * offset, player.transform.position.x + off);
                    j++;
                    totalGrass = totalGrass + numberOfGrass;
                }
                else
                {
                    j++;
                }
                
                
            }
         
            
            
            
        }


    }



    void spawnGrass(float positionX, float hugeOffset)
    {
        Instantiate(grass, new Vector3(transform.position.x + positionX + hugeOffset, transform.position.y, 0), transform.rotation, parent);
    }
   
}

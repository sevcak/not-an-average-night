using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoutingGrass : MonoBehaviour
{
    [SerializeField]
    private int numberNeeded;
    [SerializeField]
    private int currentNumber;
    [SerializeField]
    private GameObject player;
    [SerializeField]
    private GameObject alarm;
    [SerializeField]
    private Text score;

    private bool isSpawned = false;
    void Update()
    {
        if(currentNumber >= numberNeeded && !isSpawned)
        {
            isSpawned = true;
            Instantiate(alarm, new Vector2(player.transform.position.x + 5, player.transform.position.y - 0.5f), transform.rotation);
        }
        score.text = getCuttedGrass() + "/" + numberNeeded;
    }

    public void addCuttedGrass()
    {
        currentNumber++;
    }

    public int getCuttedGrass()
    {
        return currentNumber;
    }
}

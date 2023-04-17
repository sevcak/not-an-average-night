using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChange : MonoBehaviour
{
    [SerializeField]
    private CurrentPlaytrough dataSaves;
    [SerializeField]
    private Scenes scenes;
    [SerializeField]
    private PlayTroughCount infoData;

    private bool isStanding = false;
    private int randomLevel;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && isStanding)
        {
            infoData.levelsCompleted++;
            infoData.LevelCompleted[dataSaves.currentLevel]++;
            if (dataSaves.maxLevels == dataSaves.levelCount)
            {
                Debug.Log("Pred");
                SceneManager.LoadScene("MainMenu");
                infoData.nightFullyRested++;
                Debug.Log("Po");
            }
            else
            {
                do
                {
                    randomLevel = Random.Range(0, scenes.scenesIndex.Length);
                } while (dataSaves.Level[randomLevel]);


                
                dataSaves.Level[randomLevel] = true;
                dataSaves.levelCount++;
                dataSaves.currentLevel = randomLevel;
                SceneManager.LoadScene(scenes.scenesIndex[randomLevel]);
            }

            
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

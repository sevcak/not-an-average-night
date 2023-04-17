using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoingInToSleep : MonoBehaviour
{
    [SerializeField]
    private CurrentPlaytrough dataSaves;
    [SerializeField]
    private GameObject spaceInfo;
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
            //dataSaves.maxLevels = Random.Range(3, 8);
            dataSaves.maxLevels = 2;
            dataSaves.levelCount = 0;
            infoData.nightSlept++;
            for (int i = 0; i < dataSaves.Level.Length; i++)
            {
                dataSaves.Level[i] = false;
            }
            do
            {
                randomLevel = Random.Range(0, scenes.scenesIndex.Length);
            } while (dataSaves.Level[randomLevel]);


            Debug.Log(randomLevel);
            dataSaves.Level[randomLevel] = true;
            dataSaves.currentLevel = randomLevel;
            dataSaves.levelCount++;
            SceneManager.LoadScene(scenes.scenesIndex[randomLevel]);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            spaceInfo.SetActive(true);
            isStanding = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            spaceInfo.SetActive(false);
            isStanding = false;
        }
    }
}

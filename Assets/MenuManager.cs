using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    [SerializeField]
    private Text nightSlept;
    [SerializeField]
    private Text fullyRested;
    [SerializeField]
    private Text dreamsOutlived;
    [SerializeField]
    private PlayTroughCount data;
    [SerializeField]
    private GameObject[] posters;
    void Start()
    {
        NightsOver();
        FullyRan();
        Outlived();
        posterUpdate();
    }

    void Update()
    {
        
    }

    private void NightsOver()
    {
        nightSlept.text = "Nights slept: " + data.nightSlept.ToString();
    }

    private void FullyRan()
    {
        fullyRested.text = "Nights over: " + data.nightFullyRested.ToString();
    }

    private void Outlived()
    {
        dreamsOutlived.text = "Dreams over: " + data.levelsCompleted.ToString();
    }

    private void posterUpdate()
    {
        for (int i = 0; i < data.LevelCompleted.Length; i++)
        {
            if (data.LevelCompleted[i] > 0)
            {
                posters[i].SetActive(true);
            }
        }
        
    }
}

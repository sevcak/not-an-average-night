using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObject/PlaytroughCount", order = 1)]
public class PlayTroughCount : ScriptableObject
{
    public int nightSlept;
    public int nightFullyRested;
    public int levelsCompleted;
    public int[] LevelCompleted;
}

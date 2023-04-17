using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObject/CurrentPlaytrough", order = 2)]
public class CurrentPlaytrough : ScriptableObject
{
    public bool[] Level;
    public int currentLevel;
    public int levelCount;
    public int maxLevels;
}

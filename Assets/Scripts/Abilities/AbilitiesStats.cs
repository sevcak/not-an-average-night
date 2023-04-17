using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilitiesStats : MonoBehaviour
{
    [SerializeField]
    private float timeActive;
    [SerializeField]
    private float cooldown;

    public float getTimeActive()
    {
        return timeActive;
    }

    public float getCooldown()
    {
        return cooldown;
    }
}

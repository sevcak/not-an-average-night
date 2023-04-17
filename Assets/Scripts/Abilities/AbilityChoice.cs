using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityChoice : MonoBehaviour
{
    [SerializeField]
    private GameObject[] weapons;
    [SerializeField]
    private GameObject pickedWeapon;

    private GameObject player;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        for (int i = 0; i < weapons.Length; i++)
        {
            if(weapons[i] == pickedWeapon)
            {
                player.GetComponent<AbilitiesUse>().abilitySwitch(i);
            }
        }
    }

}

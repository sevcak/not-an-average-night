using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilitiesUse : MonoBehaviour
{
    [SerializeField]
    private Animator playerAnimator;
    [SerializeField]
    private GameObject[] abilities;
    [SerializeField]
    private GameObject currentAbility;
    [SerializeField]
    private bool isReady;
    [SerializeField]
    private AudioSource shink;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < abilities.Length; i++)
        {
            abilities[i].SetActive(false);
        }
        currentAbility.SetActive(false);
        isReady = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isReady)
        {
            currentAbility.SetActive(true);
            isReady = false;
            StartCoroutine(deActivateAbility());
            StartCoroutine(setIsReady());
            if (currentAbility == abilities[2])
            {
                playerAnimator.SetTrigger("Reap");
                shink.Play();
            }
        }
        
    }

    private IEnumerator deActivateAbility()
    {
        yield return new WaitForSeconds(currentAbility.GetComponent<AbilitiesStats>().getTimeActive());
        currentAbility.SetActive(false);
    }

    private IEnumerator setIsReady()
    {
        yield return new WaitForSeconds(currentAbility.GetComponent<AbilitiesStats>().getCooldown());
        isReady = true;
    }

    public void abilitySwitch(int i)
    {
        currentAbility = abilities[i];
    }
}

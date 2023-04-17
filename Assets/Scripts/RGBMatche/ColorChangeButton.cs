using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangeButton : MonoBehaviour
{
    [SerializeField]
    private int position;
    [SerializeField]
    private bool isStanding;
    [SerializeField]
    private float waitTime;
    [SerializeField]
    private GameObject manager;
    [SerializeField]
    private SpriteRenderer button;
    [SerializeField]
    private Sprite startBtn;
    [SerializeField]
    private Sprite EndBtn;
    // Update is called once per frame
    void Update()
    {
        if(isStanding && Input.GetKeyDown(KeyCode.E))
        {
            manager.GetComponent<RGBManager>().colorSetter(position);
            StartCoroutine(spriteChange());
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isStanding = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isStanding = false;
        }
    }

    private IEnumerator spriteChange()
    {
        button.sprite = EndBtn;
        yield return new WaitForSeconds(waitTime);
        button.sprite = startBtn;
    }
}

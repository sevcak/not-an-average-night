using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RGBManager : MonoBehaviour
{
    [SerializeField]
    private GameObject colorToHit;
    [SerializeField]
    private GameObject changingColor;
    [SerializeField]
    private float[] randomColor;
    [SerializeField]
    private float[] setColor = { 0, 0, 0 };
    [SerializeField]
    private Color colorBuffer;
    [SerializeField]
    private GameObject nextLevel;
    [SerializeField]
    private Text currentColorR;
    [SerializeField]
    private Text currentColorG;
    [SerializeField]
    private Text currentColorB;
    void Start()
    {
        for (int i = 0; i < randomColor.Length; i++)
        {
            randomColor[i] = Random.Range(0, 256);
        }

        colorBuffer = new Color(randomColor[0] / 255, randomColor[1] / 255, randomColor[2] / 255, 1);
        colorToHit.GetComponent<SpriteRenderer>().color = colorBuffer;
    }

    // Update is called once per frame
    void Update()
    {
        changingColor.GetComponent<SpriteRenderer>().color = new Color(setColor[0] / 255, setColor[1] / 255, setColor[2] / 255, 1);
    
        nextLevel.SetActive(chceckForResulut());
        Debug.Log(chceckForResulut());

        currentColorB.text = "Blue: " + getBlue();
        currentColorG.text = "Green: " + getGreen();
        currentColorR.text = "Red: " + getRed();
    }


    public void colorSetter(int value)
    {
        switch (value)
        {
            case 1:
                setColor[0] += 5;
                break;
            case 2:
                setColor[0] -= 5;
                break;
            case 3:
                setColor[1] += 5;
                break;
            case 4:
                setColor[1] -= 5;
                break;
            case 5:
                setColor[2] += 5;
                break;
            case 6:
                setColor[2] -= 5;
                break;
        }

        for (int i = 0; i < setColor.Length; i++)
        {
            if (setColor[i] > 255)
            {
                setColor[i] = 255;
            }

            if (setColor[i] < 0)
            {
                setColor[i] = 0;
            }
        }
    }

    private bool chceckForResulut()
    {
        for (int i = 0; i < setColor.Length; i++)
        {
            if (randomColor[i] + 20 < setColor[i] || setColor[i] < randomColor[i] -20)
            {
                return false;
            }
        }
        return true;
    }

    public float getRed()
    {
        return setColor[0];
    }

    public float getGreen()
    {
        return setColor[1];
    }

    public float getBlue()
    {
        return setColor[2];
    }
}

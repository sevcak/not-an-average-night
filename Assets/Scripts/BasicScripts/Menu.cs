using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("1", 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            ToDream();
        }
    }

    public void ToDream()
    {
        SceneManager.LoadScene(Random.Range(0, SceneManager.sceneCountInBuildSettings + 1));
    }

    private int Randoms()
    {
        return 0;
    }
}

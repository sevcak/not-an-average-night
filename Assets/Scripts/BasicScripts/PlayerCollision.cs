using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    //collision script
    private void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Soul":
            case "SpiderWeb":
            case "Chaser":
                SceneManager.LoadScene("MainMenu");
                break;
            
        
        }


    }
    
}

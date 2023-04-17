using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGrassScript : MonoBehaviour
{
    [SerializeField] private GameObject grass;
    [SerializeField] private GameObject cutedGrass;
    [SerializeField] private GameObject player;
    [SerializeField] private SpawnGrass deleteGrass;
   
    // Start is called before the first frame update
    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("grass") )
        {
            Debug.Log("hit");
            Destroy(grass);
        }
        Debug.Log("ne");
    }*/

    private void Start()
    {
        
        player = GameObject.FindGameObjectWithTag("Player");

    }

    private void Update()
    {
        
        if ((player.transform.position.x + 20) < transform.position.x || (player.transform.position.x - 20) > transform.position.x)
        {
            Destroy(grass);

        }
    }

    public void cutGrass()
    {
        GetComponentInParent<CoutingGrass>().addCuttedGrass();
        Instantiate(cutedGrass, transform.position, transform.rotation);
        Destroy(this.gameObject);
    }
}

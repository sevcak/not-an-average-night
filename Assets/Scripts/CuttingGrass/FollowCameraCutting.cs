using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCameraCutting : MonoBehaviour
{
    [SerializeField] private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + new Vector3(0, 2, -8);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Transform respawnPoint;

    public GameObject playerPrefab;

    public void RespwanPlayer()
    {
        if (playerPrefab && respawnPoint)
        {
            Instantiate(playerPrefab, respawnPoint.position, Quaternion.identity);
        }
    }
    // // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }
}

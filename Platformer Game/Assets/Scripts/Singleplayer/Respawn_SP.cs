using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn_SP : MonoBehaviour
{
    public Transform player;
    public Transform respawnPoint;
    public GameManager_SP managerGame_SP;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerOne"))
        {
            managerGame_SP.managerAudio_SP.Fall();
            player.transform.position = respawnPoint.transform.position;
            Physics.SyncTransforms();
        }
    }

}
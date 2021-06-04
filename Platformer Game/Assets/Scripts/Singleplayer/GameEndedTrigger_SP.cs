using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameEndedTrigger_SP : MonoBehaviour
{
    public GameManager_SP managerGame_SP;

    private void Start()
    {
        Time.timeScale = 1;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerOne"))
        {
            managerGame_SP.managerUI_SP.playerEndingTrigger();
            managerGame_SP.managerAudio_SP.GameEnded();
            Cursor.lockState = CursorLockMode.None;
        }
    }
}

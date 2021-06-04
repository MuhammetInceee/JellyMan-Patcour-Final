using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager_SP : MonoBehaviour
{
    public GameObject pauseScreen;
    public GameObject levelEndingScreenPlayer;
    public AudioManager_SP managerAudio_SP;

    void Start()
    {

    }

    void Update()
    {

    }
    public void GameResume()
    {
        Time.timeScale = 1;
        pauseScreen.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void GameStopped()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Time.timeScale = 0;
            pauseScreen.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
        }
    }
    public void playerEndingTrigger()
    {
        Time.timeScale = 0;

        levelEndingScreenPlayer.SetActive(true);
    }
}
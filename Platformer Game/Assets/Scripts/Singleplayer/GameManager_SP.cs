using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager_SP : MonoBehaviour
{
    public UIManager_SP managerUI_SP;
    public AudioManager_SP managerAudio_SP;

    public void doExitGame()
    {
        Application.Quit();
    }
    public void meinMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void Restart()
    {
        SceneManager.LoadScene(2);
    }

    public void ResumeGame()
    {
        managerUI_SP.GameResume();
    }
}

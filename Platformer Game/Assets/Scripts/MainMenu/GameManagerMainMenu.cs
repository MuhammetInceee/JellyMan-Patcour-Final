using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManagerMainMenu : MonoBehaviour
{
    public UIManagerMainMenu managerUI;
    public AudioManager managerAudio;
    public void Exit()
    {
        Application.Quit();
    }
    public void Sound()
    {
        if (managerAudio.bgMusic.mute)
        {
            managerAudio.bgMusic.mute = false;
        }
        else
        {
            managerAudio.bgMusic.mute = true;
        }
    }
    public void Play_SP()
    {
        SceneManager.LoadScene(2);
    }
    public void Play_MP()
    {
        SceneManager.LoadScene(1);
    }
    public void Controller()
    {
        managerUI.Controller();
    }
    public void ReturnMainMenu()
    {
        managerUI.ReturnMainMenu();
    }
    public void SP_Controller()
    {
        managerUI.SP_Controller();
    }
    public void MP_Controller()
    {
        managerUI.MP_Controller();
    }
}

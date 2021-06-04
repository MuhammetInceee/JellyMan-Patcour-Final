using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager_SP : MonoBehaviour
{
    public AudioSource jumpSound;
    public AudioSource bgMusic;
    public AudioSource winMusic;
    public AudioSource fallSound;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            if (bgMusic.mute)
            {
                bgMusic.mute = false;
            }
            else
            {
                bgMusic.mute = true;
            }
        }
    }
    public void GameEnded()
    {
        winMusic.Play();
        bgMusic.Stop();
    }
    public void Fall()
    {
        fallSound.Play();
    }
}

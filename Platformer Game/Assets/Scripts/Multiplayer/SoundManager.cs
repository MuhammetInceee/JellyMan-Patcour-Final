using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource P1_Jump;
    public AudioSource P2_Jump;
    public AudioSource bgMusic;
    public AudioSource P1_Winnig;
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
        bgMusic.Stop();
        P1_Winnig.Play();
    }
    public void Fall()
    {
        fallSound.Play();
    }
}

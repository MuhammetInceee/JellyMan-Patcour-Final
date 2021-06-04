using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameEndedTrigger : MonoBehaviour
{
    public GameManager managerGame;

    private void Start()
    {
        Time.timeScale = 1;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerOne"))
        {
            managerGame.managerUI.playerOneEndingTrigger();
            managerGame.managerSound.GameEnded();
            managerGame.timerP1.Finishh();
        }

        if (other.CompareTag("PlayerTwo"))
        {
            managerGame.managerUI.playerTwoEndingTrigger();
            managerGame.managerSound.GameEnded();
            managerGame.timerP2.Finishh();
        }
    }
}

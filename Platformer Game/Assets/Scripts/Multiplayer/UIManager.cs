using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject playerTwo_Text;
    public GameObject playerOne_text;
    public GameObject screenDivider;
    public GameObject pauseScreen;
    public GameObject levelEndingScreenPlayerOne;
    public GameObject levelEndingScreenPlayerTwo;

    public void GameResume()
    {
        Time.timeScale = 1;
        screenDivider.SetActive(true);
        playerTwo_Text.SetActive(true);
        playerOne_text.SetActive(true);
        pauseScreen.SetActive(false);
    }
    public void GameStopped()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Time.timeScale = 0;
            screenDivider.SetActive(false);
            playerTwo_Text.SetActive(false);
            playerOne_text.SetActive(false);
            pauseScreen.SetActive(true);
        }
    }
    public void playerOneEndingTrigger()
    {
        Time.timeScale = 0;
        screenDivider.SetActive(false);
        playerTwo_Text.SetActive(false);
        playerOne_text.SetActive(false);

        levelEndingScreenPlayerOne.SetActive(true);
    }
    public void playerTwoEndingTrigger()
    {
        Time.timeScale = 0;
        screenDivider.SetActive(false);
        playerTwo_Text.SetActive(false);
        playerOne_text.SetActive(false);

        levelEndingScreenPlayerTwo.SetActive(true);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public int playerScore;
    public TMP_Text playerScoreText;
    public GameObject gameOverSceen;

    [ContextMenu("Increase Score")]
    public void increaseScore(int score)
    {
        playerScore += score;
        playerScoreText.text = "Score: " + playerScore.ToString();
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverSceen.SetActive(true);
    }
}

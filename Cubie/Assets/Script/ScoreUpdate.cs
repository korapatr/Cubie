using UnityEngine;
using UnityEngine.UI;

public class ScoreUpdate : MonoBehaviour
{
    public Text scoreText;
    public Text highScoreText;

    //public int maxScore;

    private int score = 0;
    private int highScore = 0;

    private void Start()
    {
        // Load the high score from PlayerPrefs
        highScore = PlayerPrefs.GetInt("HighScore", 0);
        UpdateHighScoreText();
    }

    public void IncreaseScore(int amount)
    {
        score += amount;
        //maxScore = score;
        UpdateScoreText();

        if (score > highScore)
        {
            highScore = score;
            UpdateHighScoreText();

            // Save the new high score to PlayerPrefs
            PlayerPrefs.SetInt("HighScore", highScore);
            PlayerPrefs.Save();
        }
    }

    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }

    private void UpdateHighScoreText()
    {
        highScoreText.text = "High Score: " + highScore.ToString();
    } 
}

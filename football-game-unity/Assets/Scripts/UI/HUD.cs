using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public Text scoreText;
    public Text playerStatsText;

    private int score;
    private string playerStats;

    void Start()
    {
        score = 0;
        playerStats = "Player: 0 Goals, 0 Assists";
        UpdateHUD();
    }

    public void UpdateScore(int points)
    {
        score += points;
        UpdateHUD();
    }

    public void UpdatePlayerStats(int goals, int assists)
    {
        playerStats = $"Player: {goals} Goals, {assists} Assists";
        UpdateHUD();
    }

    private void UpdateHUD()
    {
        scoreText.text = "Score: " + score.ToString();
        playerStatsText.text = playerStats;
    }
}
using UnityEngine;

public class MatchController : MonoBehaviour
{
    public MatchSettings matchSettings;
    private float matchTime;
    private bool isMatchActive;

    void Start()
    {
        InitializeMatch();
    }

    void Update()
    {
        if (isMatchActive)
        {
            UpdateMatchTime();
        }
    }

    private void InitializeMatch()
    {
        matchTime = matchSettings.matchDuration;
        isMatchActive = true;
    }

    private void UpdateMatchTime()
    {
        matchTime -= Time.deltaTime;
        if (matchTime <= 0)
        {
            EndMatch();
        }
    }

    private void EndMatch()
    {
        isMatchActive = false;
        // Logic to handle end of match, such as displaying results
    }

    public void PlayerScored(int playerId)
    {
        // Logic to handle scoring
    }
}
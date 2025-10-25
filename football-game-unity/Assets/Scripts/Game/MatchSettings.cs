using UnityEngine;

[System.Serializable]
public class MatchSettings
{
    public float matchDuration = 90f; // Duration of the match in minutes
    public int maxScore = 10; // Maximum score for a match
    public bool allowExtraTime = true; // Allow extra time if the match is tied
    public bool allowPenalties = true; // Allow penalties if the match is tied after extra time

    // Additional settings can be added here
}
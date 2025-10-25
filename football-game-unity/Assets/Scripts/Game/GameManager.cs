using UnityEngine;

public class GameManager : MonoBehaviour
{
    private MatchController matchController;

    void Start()
    {
        matchController = GetComponent<MatchController>();
        StartMatch();
    }

    public void StartMatch()
    {
        matchController.InitializeMatch();
    }

    public void EndMatch()
    {
        // Logic to end the match and display results
    }
}
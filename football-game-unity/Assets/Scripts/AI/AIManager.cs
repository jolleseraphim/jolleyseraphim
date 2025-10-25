using UnityEngine;

public class AIManager : MonoBehaviour
{
    public GameObject playerPrefab;
    public int numberOfAIPlayers = 5;
    private GameObject[] aiPlayers;

    void Start()
    {
        SpawnAIPlayers();
    }

    void SpawnAIPlayers()
    {
        aiPlayers = new GameObject[numberOfAIPlayers];
        for (int i = 0; i < numberOfAIPlayers; i++)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(-10f, 10f), 0, Random.Range(-10f, 10f));
            aiPlayers[i] = Instantiate(playerPrefab, spawnPosition, Quaternion.identity);
            aiPlayers[i].GetComponent<PlayerController>().SetAI(true);
        }
    }

    void Update()
    {
        foreach (GameObject aiPlayer in aiPlayers)
        {
            if (aiPlayer != null)
            {
                // Implement AI behavior logic here
                aiPlayer.GetComponent<TacticalAI>().MakeDecision();
            }
        }
    }
}
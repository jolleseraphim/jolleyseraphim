using UnityEngine;

public class Stamina : MonoBehaviour
{
    public float maxStamina = 100f;
    public float currentStamina;
    public float staminaDrainRate = 5f;
    public float staminaRecoveryRate = 2f;

    private void Start()
    {
        currentStamina = maxStamina;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.W)) // Example input for running
        {
            DrainStamina();
        }
        else
        {
            RecoverStamina();
        }
    }

    private void DrainStamina()
    {
        if (currentStamina > 0)
        {
            currentStamina -= staminaDrainRate * Time.deltaTime;
            currentStamina = Mathf.Max(currentStamina, 0);
        }
    }

    private void RecoverStamina()
    {
        if (currentStamina < maxStamina)
        {
            currentStamina += staminaRecoveryRate * Time.deltaTime;
            currentStamina = Mathf.Min(currentStamina, maxStamina);
        }
    }

    public float GetCurrentStamina()
    {
        return currentStamina;
    }
}
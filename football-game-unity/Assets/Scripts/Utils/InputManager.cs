using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static InputManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public Vector2 GetMovementInput()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        return new Vector2(moveHorizontal, moveVertical);
    }

    public bool GetKickInput()
    {
        return Input.GetButtonDown("Fire1");
    }

    public bool GetPassInput()
    {
        return Input.GetButtonDown("Fire2");
    }

    public bool GetSprintInput()
    {
        return Input.GetButton("Fire3");
    }
}
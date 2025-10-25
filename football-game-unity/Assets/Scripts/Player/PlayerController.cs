using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float sprintMultiplier = 1.5f;
    public float rotationSpeed = 720f;

    private Animator animator;
    private Rigidbody rb;
    private Vector3 movementInput;
    private bool isSprinting;
    private Vector3 lastPosition;
    private float movementThreshold = 0.1f;
    private float idleTime = 0f;
    private float idleThreshold = 2f;
    private float lastMoveTime;
    private float animationBlendSpeed = 5f;
    private float currentBlend;
    private float targetBlend;
    private AI tacticalAI;
    private BallPhysics ballPhysics;
    private float kickPower = 10f;
    private float kickCooldown = 1f;
    private float lastKickTime;
    private bool isKicking;
    private Vector3 kickDirection;
    private float slidetackleDuration = 0.5f;
    private float slidetackleTimer;
    private bool isSlidetackling;   
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        ballPhysics = GetComponent<BallPhysics>();
    }

    void Update()
    {
        HandleInput();
        AnimatePlayer();
    }

    void FixedUpdate()
    {
        MovePlayer();
    }

    private void HandleInput()
    {
        movementInput.x = Input.GetAxis("Horizontal");
        movementInput.z = Input.GetAxis("Vertical");
        isSprinting = Input.GetKey(KeyCode.LeftShift);
    }

    private void MovePlayer()
    {
        Vector3 moveDirection = new Vector3(movementInput.x, 0, movementInput.z).normalized;
        if (moveDirection.magnitude >= 0.1f)
        {
            float speed = isSprinting ? moveSpeed * sprintMultiplier : moveSpeed;
            rb.MovePosition(rb.position + moveDirection * speed * Time.fixedDeltaTime);
            Quaternion targetRotation = Quaternion.LookRotation(moveDirection);
            rb.rotation = Quaternion.RotateTowards(rb.rotation, targetRotation, rotationSpeed * Time.fixedDeltaTime);
        }
    }

    private void AnimatePlayer()
    {
        animator.SetFloat("Speed", movementInput.magnitude);
        animator.SetBool("IsSprinting", isSprinting);
    }
}
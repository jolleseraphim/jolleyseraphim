using UnityEngine;

public class BallPhysics : MonoBehaviour
{
    public float speed = 10f;
    public float bounceFactor = 0.5f;
    public float drag = 0.1f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.drag = drag;
    }

    void Update()
    {
        // Apply movement based on user input or AI
        MoveBall();
    }

    void MoveBall()
    {
        // Example movement logic
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector3.forward * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector3.back * speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector3.left * speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector3.right * speed);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // Handle ball bouncing
        Vector3 bounceDirection = Vector3.Reflect(rb.velocity.normalized, collision.contacts[0].normal);
        rb.velocity = bounceDirection * bounceFactor * rb.velocity.magnitude;
    }
}
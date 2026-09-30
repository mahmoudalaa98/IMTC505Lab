using UnityEngine;

public class DropBall : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 startPosition;

    [SerializeField] private float bounceForce = 7f;
    [SerializeField] private float sideForce = 4f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        startPosition = transform.position;
        rb.useGravity = false;
    }

    void Update()
    {
        // Drop/reset the ball
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position = startPosition;

            rb.linearVelocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;

            rb.useGravity = true;
        }

        // Bounce and change direction
        if (Input.GetKeyDown(KeyCode.B))
        {
            rb.useGravity = true;

            rb.AddForce(
                new Vector3(sideForce, bounceForce, 0),
                ForceMode.Impulse
            );

            sideForce = -sideForce;
        }
    }
}
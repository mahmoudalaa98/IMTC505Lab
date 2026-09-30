using UnityEngine;

public class Rocket123 : MonoBehaviour
{
    [SerializeField] private float radius = 5f;
    [SerializeField] private float speed = 2f;

    private float angle = 0f;
    private bool isMoving = false;
    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isMoving = !isMoving;
        }

        if (isMoving)
        {
            angle += speed * Time.deltaTime;

            float x = Mathf.Cos(angle) * radius;
            float y = Mathf.Sin(angle) * radius;

            transform.position = new Vector3(
                startPosition.x + x,
                startPosition.y + y,
                startPosition.z
            );
        }
    }
}
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public float joystickSensibilite = 0.1f;

    private Rigidbody2D rb;
    private Vector2 joystickInput;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector2 movement = joystickInput.normalized * speed;

        rb.MovePosition(rb.position + movement * Time.fixedDeltaTime);

        Debug.Log("Spamton Become a [BIG SHOT!]");
    }

    public void SetJoystickInput(Vector2 input)
    {
        joystickInput = (Mathf.Abs(input.x) < joystickSensibilite && Mathf.Abs(input.y) < joystickSensibilite) ? Vector2.zero : input;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("TOUCHER !");
    }
}

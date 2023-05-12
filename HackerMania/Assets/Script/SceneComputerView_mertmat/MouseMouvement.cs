using UnityEngine;

public class MouseMouvement : MonoBehaviour
{
    public float normalSpeed = 5f;
    public float boostSpeed = 10f;
    public float minPos;

    private Rigidbody2D rb;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        
        Vector3 newPos = new Vector3 (horizontal, vertical, 0); 

        // V�rifier si le joystick gauche est utilis� pour d�placer le joueur
        if (Mathf.Abs(horizontal) > 0.1f || Mathf.Abs(vertical) > 0.1f)
        {
            // V�rifier si le bouton A est enfonc� pour augmenter la vitesse
            if (Input.GetKey(KeyCode.JoystickButton2))
            {
                rb.MovePosition(rb.position + new Vector2(horizontal, vertical) * boostSpeed * Time.fixedDeltaTime);
            }
            else
            {
                rb.MovePosition(rb.position + new Vector2(horizontal, vertical) * normalSpeed * Time.fixedDeltaTime);
            }
        }
    }
}
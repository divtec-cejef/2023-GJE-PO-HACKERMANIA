using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public float normalSpeed = 5f;
    public float boostSpeed = 10f;
    public bool isRunning = false;

    private Rigidbody2D rb;

    private GameObject pushableObject;
    private bool isPushing = false;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Vérifier si le joystick gauche est utilisé pour déplacer le joueur
        if (Mathf.Abs(horizontal) > 0.1f || Mathf.Abs(vertical) > 0.1f)
        {
            // Vérifier si le bouton A est enfoncé pour augmenter la vitesse
            if (Input.GetKey(KeyCode.JoystickButton2))
            {
                rb.MovePosition(rb.position + new Vector2(horizontal, vertical) * boostSpeed * Time.fixedDeltaTime);
                isRunning = true;
            }
            else
            {
                rb.MovePosition(rb.position + new Vector2(horizontal, vertical) * normalSpeed * Time.fixedDeltaTime);
                isRunning = false;
            }
        }

        if (isPushing && pushableObject != null)
        {
            // Calculer la direction dans laquelle pousser l'objet
            Vector2 pushDirection = pushableObject.transform.position - transform.position;
            pushDirection.Normalize();

            // Pousser l'objet en fonction de la direction et de la vitesse du joueur
            pushableObject.GetComponent<Rigidbody2D>().velocity = pushDirection * normalSpeed;
        }

        if (horizontal > 0) 
        { 
            transform.localScale = new Vector3(-1, transform.localScale.y, transform.localScale.z); 
        } 
        else if (horizontal < 0) 
        {
            transform.localScale = new Vector3(1, transform.localScale.y, transform.localScale.z); 
        }

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collision détectée");
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Caisse") && Input.GetButton("Jump"))
        {
            isPushing = true;
            pushableObject = collision.gameObject;
        }
        else
        {
            isPushing = false;
            pushableObject = null;
        }
    }
}
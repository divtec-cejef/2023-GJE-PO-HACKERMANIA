using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public float normalSpeed = 5f;
    public float boostSpeed = 10f;
    public bool isRunning = false;

    public Animator animator;
    public DirectionalAnimations animations;

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
            if (Input.GetKey(KeyCode.JoystickButton2) || Input.GetKey(KeyCode.LeftShift))
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
        else
        {
            isRunning = false;
        }

        // Mettre à jour l'animation en fonction de la direction de déplacement
        if (vertical < 0 && Mathf.Abs(horizontal) < 0.1f)
        {
            animator.Play(animations.DownAnimation);
        }
        else if (vertical > 0 && Mathf.Abs(horizontal) < 0.1f)
        {
            animator.Play(animations.UpAnimation);
        }
        else if (Mathf.Abs(horizontal) > 0.1f)
        {
            if (horizontal < 0)
            {
                animator.Play(animations.LeftAnimation);
            }
            else
            {
                animator.Play(animations.RightAnimation);
            }
        }
        else
        {
            // Si le joueur ne bouge pas, jouer l'animation "idle"
            animator.Play(animations.IdleAnimation);
        }

        if (isPushing && pushableObject != null)
        {
            // Calculer la direction dans laquelle pousser l'objet
            Vector2 pushDirection = pushableObject.transform.position - transform.position;
            pushDirection.Normalize();

            // Pousser l'objet en fonction de la direction et de la vitesse du joueur
            pushableObject.GetComponent<Rigidbody2D>().velocity = pushDirection * normalSpeed;
        }
    }
}

[System.Serializable]
public class DirectionalAnimations
{
    public string UpAnimation;
    public string DownAnimation;
    public string LeftAnimation;
    public string RightAnimation;
    public string IdleAnimation;
}

using UnityEngine;
using UnityEngine.UI;

public class SoundBar : MonoBehaviour
{
    public float maxHealth = 1.0f;
    public float health = 1.0f;
    public float healthDecreaseRate = 0.1f;

    public Image fillImage;

    private PlayerMovement playerMovement;

    void Start()
    {
        playerMovement = FindObjectOfType<PlayerMovement>();
        health = maxHealth;
        UpdateHealthBar();
    }

    void UpdateHealthBar()
    {
        fillImage.fillAmount = health / maxHealth;
    }

    void DecreaseHealth()
{
    if (playerMovement.isRunning)
    {
        health -= healthDecreaseRate;
    }
    else
    {
        health += healthDecreaseRate;
    }
    health = Mathf.Clamp(health, 0f, maxHealth); // Limiter la santé entre 0 et maxHealth
    UpdateHealthBar();
}

    void OnEnable()
    {
        InvokeRepeating("DecreaseHealth", 1f, 0.35f);
    }

    void OnDisable()
    {
        CancelInvoke("DecreaseHealth");
    }
}
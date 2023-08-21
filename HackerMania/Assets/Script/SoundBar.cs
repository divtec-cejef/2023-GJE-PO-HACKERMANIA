using UnityEngine;
using UnityEngine.UI;

public class SoundBar : MonoBehaviour
{
    public float maxHealth = 1.0f;
    public float health = 1.0f;
    public float healthDecreaseRate = 0.1f;
    public bool GuardienActif = true;

    public Image fillImage;

    private PlayerMovement playerMovement;
    private Transform playerTransform;
    public float proximityDistance = 2.0f; // Distance de proximité pour la diminution de la vie

    void Start()
    {
        playerMovement = FindObjectOfType<PlayerMovement>();
        playerTransform = playerMovement.transform;
        health = maxHealth;
        UpdateHealthBar();
    }

    void UpdateHealthBar()
    {
        fillImage.fillAmount = health / maxHealth;
    }

    void DecreaseHealth()
    {
        if (playerMovement.isRunning || IsPlayerTooClose())
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

    bool IsPlayerTooClose()
    {
        float distance = Vector3.Distance(transform.position, playerTransform.position);
        return distance < proximityDistance;
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
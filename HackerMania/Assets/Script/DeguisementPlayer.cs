using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeguisementPlayer : MonoBehaviour
{
    public PlayerMovement playerMovement;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Le joueur est déguiser !");
            playerMovement.estDeguiser = true;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CauseOfLifeLoss : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerControllerCapsule playerController = collision.GetComponent<PlayerControllerCapsule>();

            if (playerController != null)
            {
                playerController.LoseLife();
            }
        }
    }
}

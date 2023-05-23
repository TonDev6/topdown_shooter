using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpeed : MonoBehaviour
{
    
    public float durationPowerUp = 5f;
    public float speedUpper = 3f;
    
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.CompareTag("Player"))
            ApplyPowerUp(other.gameObject);
            DestroyPowerUp();
    }

    private void ApplyPowerUp(GameObject player)
    {
        PlayerController move = player.GetComponent<PlayerController>();
        move.SpeedUpTemp(speedUpper, durationPowerUp);
    }

    private void DestroyPowerUp()
    {
        Destroy(gameObject);
    }
}

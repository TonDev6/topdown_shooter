using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpeed : MonoBehaviour
{
    
    public float durationPowerUp = 5f;
    public float speedUpper = 3f;
    
    //Verifica a colisão e destrói o iten de powerup quando "coletado"
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.CompareTag("Player"))
            ApplyPowerUp(other.gameObject);
            DestroyPowerUp();
    }

    //Chama a função dentro do Script do Jogador
    private void ApplyPowerUp(GameObject player)
    {
        PlayerController move = player.GetComponent<PlayerController>();
        move.SpeedUpTemp(speedUpper, durationPowerUp);
    }

    //Função para destruir o objeto
    private void DestroyPowerUp()
    {
        Destroy(gameObject);
    }
}

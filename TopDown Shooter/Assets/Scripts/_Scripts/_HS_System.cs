using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _HS_System : MonoBehaviour
{

    public int health, maxHealth = 10;
    public int shield, maxShield = 10;



    void Update()
    {
        if (health > maxHealth) health = maxHealth;
        if (shield > maxShield) shield = maxShield;
    }

    public void Damage(int damagePoints) {
        if (health > 0)
        {
            if (shield > 0) 
            {
                shield -= damagePoints;
            } else {
                health -= damagePoints;
            }
        }
    }

    public void Heal(int healingPoints) {
        if (health < maxHealth)
            health += healingPoints;
        
    }

    public void ShieldHeal(int shieldPoints) {
        if(shield < maxShield)
            shield += shieldPoints;
    }

}

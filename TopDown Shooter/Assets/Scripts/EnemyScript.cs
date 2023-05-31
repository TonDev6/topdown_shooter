using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    private ShootScript enemyShoot;
    
    
    private Rigidbody2D rb;

    
    public float fireRate = 5f;
    private float timeToFire = 0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        enemyShoot = GetComponent<ShootScript>();
        timeToFire = fireRate;
    }

    // Update is called once per frame
    void Update()
    {
        EnemyFire();
    }

    private void FixedUpdate() {
        
    }


    public void EnemyFire() {
        if (timeToFire <= 0f) {
            enemyShoot.Shoot();

            timeToFire = fireRate;
        } else {
            timeToFire -= Time.deltaTime;
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _ShootControl : MonoBehaviour
{
    public Transform firePoint;
    
    public GameObject bulletPrefab;
    public float bulletForce;
    private float timeToFire;

    private _Bullet bPrefab;

    bool trigger = false;



    private void Awake() {
        bulletForce = bPrefab.bulletSpeed;
        timeToFire = bPrefab.fireRate;
    }

    private void Update() {
        Shoot();
    }


    public void Shoot() {
        if (Input.GetButtonDown("Fire1"))
        {
            trigger = true;

            if (trigger = true && timeToFire <= 0f) {
                GameObject projectile = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

                Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
                rb. AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);

                trigger = false;
            } else {
                timeToFire -= Time.deltaTime;
            }
        }

    }


}

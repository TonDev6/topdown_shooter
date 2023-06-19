using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _ShootControl : MonoBehaviour
{
    public Transform firePoint;
    
    public GameObject bulletPrefab;
    public float bulletForce = 0f;
    

    private void Start() {
        
        bulletPrefab = this.gameObject.GetComponent<_WpnSelectSys>().selectedWeapon;
        bulletForce = bulletPrefab.gameObject.GetComponent<_Bullet>().bulletSpeed;
    }

    private void Update() {
        bulletPrefab = this.gameObject.GetComponent<_WpnSelectSys>().selectedWeapon;
        bulletForce = bulletPrefab.gameObject.GetComponent<_Bullet>().bulletSpeed;
    }

    public void Shoot() {
        GameObject projectile = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
        rb. AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
    }
}

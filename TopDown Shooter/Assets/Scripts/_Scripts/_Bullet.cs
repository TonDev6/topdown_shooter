using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _Bullet : MonoBehaviour
{
    public int bulletDamage = 1;
    public float bulletSpeed = 20f;

    public float fireRate = 1.5f;

    private void OnCollisionEnter2D(Collision2D other) {
        Destroy(gameObject);
    }
}
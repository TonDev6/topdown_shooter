using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _Bullet : MonoBehaviour
{
    public int bulletDamage;
    public float bulletSpeed;

    public float fireRate;

    private void OnCollisionEnter2D(Collision2D other) {
        Destroy(gameObject);
    }
}
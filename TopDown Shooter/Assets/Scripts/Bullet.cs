using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public int bulletDamage = 1;

    private void OnCollisionEnter2D(Collision2D other) {
        Destroy(gameObject);
    }
}

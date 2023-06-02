using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpdChange : MonoBehaviour
{
    public GameObject player;
    public GameObject pweapon;
    public _ShootControl pshooting;
    public GameObject blltPrefab;

    public float pFireRate;

    public float speedChange = 0f;  

    private void Awake() {
        player = GameObject.FindGameObjectWithTag("Player").gameObject;

        pweapon = player.transform.GetChild(0).gameObject;

        pshooting = pweapon.GetComponent<_ShootControl>();

        blltPrefab = pshooting.bulletPrefab;

        pFireRate = blltPrefab.gameObject.GetComponent<_Bullet>().fireRate;
    }  

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.CompareTag("Bullet")) {
            
            pFireRate = pFireRate * speedChange;
        }
    }
}

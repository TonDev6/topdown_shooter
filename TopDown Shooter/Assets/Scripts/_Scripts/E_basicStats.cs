using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_basicStats : MonoBehaviour
{
    public _HealthShield e_HealthShield;
    public _HS_System e_HSValues;

    public GameObject childBody;

    public e_Aim_n_Move aim_Move;

    public int pDamage;

    private void Start() {
        e_HealthShield = GetComponent<_HealthShield>();
        e_HSValues = GetComponent<_HS_System>();
        aim_Move = GetComponent<e_Aim_n_Move>();

        e_HSValues.health = 10;
        e_HSValues.shield = 10;
    }

    private void Update() {
        if (e_HSValues.health > 0) {
        aim_Move.Aim_n_Move();
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Bullet")) {
            pDamage = other.gameObject.GetComponent<_Bullet>().bulletDamage;
            e_HSValues.Damage(pDamage);
        }
    }
}

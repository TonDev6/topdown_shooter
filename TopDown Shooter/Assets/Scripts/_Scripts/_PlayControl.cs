using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _PlayControl : MonoBehaviour
{
    private _ShootControl shooting;
    private _Bullet bDamage;    
    public _HealthShield healthshield;
    public _HS_System hsValues;

    

    public float speed = 4f;
    private Rigidbody2D rb;
    
    private void Awake() {
        rb = GetComponent<Rigidbody2D>();
        healthshield = GetComponent<_HealthShield>();
        hsValues = GetComponent<_HS_System>();
        bDamage = GetComponent<_Bullet>();
        shooting = GetComponent<_ShootControl>();
    }

    private void Start() {
        hsValues.health = 5;
        hsValues.shield = 5;
    }
    
    private void FixedUpdate() {
        float xMove = Input.GetAxis("Horizontal");
        float yMove = Input.GetAxis("Vertical");

        Vector2 move = new Vector2(xMove, yMove);
        rb.velocity = move * speed;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Vector2 direction = new Vector2(mousePosition.x - transform.position.x, mousePosition.y - transform.position.y);

        transform.up = direction;

        shooting.Shoot();
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.CompareTag("Bullet")) {
            hsValues.Damage(bDamage.bulletDamage);
        }
    }
}

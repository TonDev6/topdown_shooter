using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    private ShootScript enemyShoot;
    
    
    public Transform target;
    public float speed = 3f;
    public float rotateSpeed = 0.0025f;
    private Rigidbody2D rb;

    public float distanceToStop = 3f;
    public float distanceToShoot = 5f;

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
        RotateTowardsTarget();

        if (Vector2.Distance(target.position, transform.position) <= distanceToShoot) {
            EnemyFire();
        }
    }

    private void FixedUpdate() {
        if (Vector2.Distance(target.position, transform.position) >= distanceToStop) {
            rb.velocity = transform.up * speed;
        } else {
            rb.velocity = Vector2.zero;
        }
    }


    private void GetTarget(){
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void RotateTowardsTarget() {
        Vector2 targetDirection = target.position - transform.position;
        float angle = Mathf.Atan2(targetDirection.y, targetDirection.x) * Mathf.Rad2Deg - 90f;
        Quaternion q = Quaternion.Euler(new Vector3(0,0, angle));
        transform.localRotation = Quaternion.Slerp(transform.localRotation, q, rotateSpeed);
    }

    public void EnemyFire() {
        if (timeToFire <= 0f) {
            enemyShoot.Shoot();

            timeToFire = fireRate;
        } else {
            timeToFire -= Time.deltaTime;
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.CompareTag("Player")) {
            Debug.Log("Hello");
            target = null;
        }
    }
}
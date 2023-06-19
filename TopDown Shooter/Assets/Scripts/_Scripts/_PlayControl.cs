using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _PlayControl : MonoBehaviour
{
    [SerializeField] private _ShootControl shooting;
    [SerializeField] private _HealthShield healthshield;
    public _HS_System hsValues;

    [SerializeField] private GameObject weapon;
    [SerializeField] private GameObject projPrefab;


    public float fireRate;
    public float timeToFire = 0f;
    public int bDamage;


    

    public float speed = 4f;
    
    private void Awake() {
        healthshield = GetComponent<_HealthShield>();
        hsValues = GetComponent<_HS_System>();
        weapon = transform.GetChild(0).gameObject;
        shooting = weapon.GetComponent<_ShootControl>();

        projPrefab = shooting.bulletPrefab;

        bDamage = projPrefab.gameObject.GetComponent<_Bullet>().bulletDamage;

        fireRate = projPrefab.gameObject.GetComponent<_Bullet>().fireRate;
    }

    private void Start() {
        hsValues.health = 10;
        hsValues.shield = 0;
    }
    
    private void FixedUpdate() {
        float xMove = Input.GetAxis("Horizontal");
        float yMove = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(xMove, yMove, 0f);

        transform.position = transform.position + move * speed * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Vector2 direction = new Vector2(mousePosition.x - transform.position.x, mousePosition.y - transform.position.y);

        transform.up = direction;

        if (timeToFire <= 0f) {
            if(Input.GetMouseButtonDown(0)){
            shooting.Shoot();

            timeToFire = fireRate;
            }
        } else {
            timeToFire -= Time.deltaTime;
        }

    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Bullet")) {
            hsValues.Damage(bDamage);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    public float speed = 5f;
    private Rigidbody2D rb;
    private ShootScript shooting;

    private void Awake() {
        rb = GetComponent<Rigidbody2D>();
        shooting = GetComponent<ShootScript>();
    }
    
    private void FixedUpdate() {
        float xMove = Input.GetAxis("Horizontal");
        float yMove = Input.GetAxis("Vertical");

        Vector2 move = new Vector2(xMove, yMove);
        rb.velocity = move * speed;
    }

    void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = new Vector2(mousePosition.x - transform.position.x, mousePosition.y - transform.position.y);
        transform.up = direction;

        if (Input.GetButtonDown("Fire1"))
        {
            shooting.Shoot();
        }

    }

    public void SpeedUpTemp(float speedUp, float time)
    {
        StartCoroutine(SpeedUpTempCoroutine(speedUp, time));
    }

    private IEnumerator SpeedUpTempCoroutine(float speedUp, float time)
    {
        float speedOriginal = speed;
        speed += speedUp;

        yield return new WaitForSeconds(time);

        speed = speedOriginal;
    }
}

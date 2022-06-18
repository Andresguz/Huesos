using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletEnemy : MonoBehaviour
{
    public GameObject destruccion;
   // public GameObject target;
   
    Rigidbody2D rb;

    public float speed = 5;
    monkey target;
    Vector2 moveDirection;
    public GameObject pointl;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target= GameObject.FindObjectOfType<monkey>();
        moveDirection=(target.transform.position-transform.position).normalized*speed;
    rb.velocity = new Vector2 (moveDirection.x, moveDirection.y);
        Destroy(gameObject, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        //rb.velocity = new Vector2(velX, velY);
      //  rb.velocity = transform.right *- velX;
      //  Destroy(gameObject, 5f);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") )
        {
            Instantiate(destruccion, collision.transform);
            GameManager.instance.vidas--;
            Destroy(gameObject, 0.2f);
        }
        if (collision.gameObject.CompareTag("piso"))
        {

            Instantiate(destruccion, pointl.transform);
            Destroy(gameObject, 0.2f);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") )
        {
            GameManager.instance.vidas--;
            Instantiate(destruccion, pointl.transform);
            Destroy(gameObject, 0.2f);
        }
        if ( collision.gameObject.CompareTag("piso"))
        {
         
            Instantiate(destruccion, pointl.transform);
            Destroy(gameObject, 0.2f);
        }
    }
}

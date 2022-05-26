using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public GameObject destruccion;
    public GameObject target;
    public float velX;
    public float velY=0;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //rb.velocity = new Vector2(velX, velY);
        rb.velocity = transform.right*velX;
        Destroy(gameObject,5f);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("enemigo")|| collision.gameObject.CompareTag("piso"))
        {
            Instantiate(destruccion,target.transform);
            Destroy(gameObject,0.2f);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moviemientoClase : MonoBehaviour
{
    [SerializeField]
     float speed=45.0f;
    Vector2 move;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        rb.AddForce(move * speed * Time.deltaTime);
       // rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y);
        rb.velocity = move *speed * Time.deltaTime;
       // rb.MovePosition(rb.position, rb.position);
    }
    void Update()
    {
        move = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        //transform.Translate(move*speed*Time.deltaTime);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monkey : MonoBehaviour
{
    [SerializeField]
    float velocidad = 3.0f;
    [SerializeField]
    float fuerzaSalto = 5.0f;
    public Animator MOKEY;
    public bool dano = false;
    public bool llaveActiva = false;
    float x = 1;

    public float monedas = 0;
    void Start()
    {
     

        MOKEY = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        MovimientoPlayer();


    }
    void MovimientoPlayer()
    {
        if (dano == false)
        {
            MOKEY.SetBool("jump", false);
            MOKEY.SetBool("run", false);
            MOKEY.SetBool("iddle", false);
            MOKEY.SetBool("damage", false);
            MOKEY.SetBool("atack", false);
        }
        if (Input.GetKey("e"))
        {        
            MOKEY.SetBool("atack", true);
        }
        if (Input.GetKey("q"))
        {     
            MOKEY.SetBool("damage", true);
        }
        if (Input.GetKey("d"))
        {
          MOKEY.SetBool("atack", false);
            MOKEY.SetBool("run", true);
         
            transform.Translate(Vector2.right * Time.deltaTime * velocidad);
            transform.localScale = new Vector3(-1F, 1, 1);
    
            //transform.localScale.x = Vector2(1f,0);
        }
        if (Input.GetKey("a"))
        {
            MOKEY.SetBool("atack", false);
            MOKEY.SetBool("run", true);
         transform.localScale = new Vector3(1F, 1, 1);
            transform.Translate(Vector2.left * Time.deltaTime * velocidad);
           // gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
        if (Input.GetKey("w") && Mathf.Abs(gameObject.GetComponent<Rigidbody2D>().velocity.y) < 0.01f)
        {
            MOKEY.SetBool("atack", false);

            gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * fuerzaSalto, ForceMode2D.Impulse);
            MOKEY.SetBool("jump", true);
//MOKEY.SetBool("iddle", false);

        }

    }
    void OnCollisionEnter2D(Collision2D collision)
    {

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("coin"))
        {
           Destroy(other.gameObject,1.0f);
            monedas++;
        }

    }
}

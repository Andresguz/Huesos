using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class monkey : MonoBehaviour
{
    // 

    [SerializeField]
    float fuerzaSalto;
    public Animator MOKEY;
    public bool dano = false;
    public bool llaveActiva = false;
    float x = 1;
   
    Vector2 move;
    public float monedas = 0;
    //public coinsManager coins;
    public CoinCollection Coinsmove;
    // GameManager gameManager;
    public Inputs inputActions;
  
    public Rigidbody2D rb;

  public  float velocidad;
    float direction = 0;
    bool isRuning = false;
    bool isJump;
    public Text vidaText;
    private void Awake()
    {
        rb=GetComponent<Rigidbody2D>();
        inputActions = new Inputs();
        inputActions.Enable();
        inputActions.Player.move.performed += ctx => { direction = ctx.ReadValue<float>(); };
        inputActions.Player.atack.performed += _ => atack();
        inputActions.Player.atack.canceled += _ => stopAtack();
        inputActions.Player.Jump.performed +=_=> jump();
        inputActions.Player.Jump.canceled +=_=> jumpStop();   
        inputActions.Player.run.performed +=_=> run();
        inputActions.Player.run.canceled +=_=> runStop();
        GameManager.instance.vidas = 3;

    }
    private void OnEnable()
    {
        inputActions.Enable();
      //  inputActions.Player.atack.started += DoAtack;
      
        inputActions.Player.Enable();
    }
    private void OnDisable()
    {
        inputActions.Disable();
  
 
        inputActions.Player.Disable();
    }


    void Start()
    {
        MOKEY = GetComponent<Animator>();
        vidaText.text=GameManager.instance.vidas.ToString();
    }
 
   
    void Update()
    {
        vidaText.text = GameManager.instance.vidas.ToString();
        if (isRuning == true)
        {
            velocidad = 10;
        }
        else
        {
            velocidad = 10;
        }
     MovimientoPlayer();


        
    }
   public void atack()
    {
        MOKEY.SetBool("atack", true);
        transform.localScale = new Vector3(-1.0F, 1.0f, 1.0f);
    }
    public void atack2()
    {
        transform.localScale = new Vector3(1.0F, 1.0f, 1.0f);
        MOKEY.SetBool("atack", true);
    }
    public void stopAtack()
    {
      
        MOKEY.SetBool("atack", false);
    }
    public void run()
    {
        //MOKEY.SetTrigger("corr");
        MOKEY.SetBool("corre", true);
        isRuning = true;
    }
    public void runStop()
    {
        MOKEY.SetBool("corre", false);
        isRuning =false;
    }
    public void MovimientoPlayer()
    {
        if (isJump==false)
        {
            MOKEY.SetBool("run", true);
        }

        if (direction < 0)
        {
            // MOKEY.SetBool("atack", false);
            MOKEY.SetBool("run", true);
          //  transform.localScale = new Vector3(1F, 1, 1);
            transform.eulerAngles = new Vector3(0, 180, 0);
 
            rb.velocity = new Vector2(direction * velocidad, rb.velocity.y);
        }
        else
        {
            MOKEY.SetBool("run", true);
            //   MOKEY.SetBool("atack", false);
            //transform.localScale = new Vector3(-1F, 1, 1);
            transform.eulerAngles = new Vector3(0, 0, 0);
            rb.velocity = new Vector2(direction * velocidad, rb.velocity.y);
        }
        if (direction == 0)
        {
            MOKEY.SetBool("run", false);
            rb.velocity = new Vector2(0, rb.velocity.y);
        }
      
   
        

    }
  public  void jumpStop()
    {
        isJump=false;
        MOKEY.SetBool("jump", false);
    }
   public void jump()
    {
        isJump=true;
      if (Mathf.Abs(gameObject.GetComponent<Rigidbody2D>().velocity.y) < 0.01f)
        {
           
            MOKEY.SetBool("atack", false);
            MOKEY.SetBool("jump", true);
            gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * fuerzaSalto, ForceMode2D.Impulse);
        
        }
      
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("piso"))
        {
            MOKEY.SetBool("jump", false);
        }
       
        if (collision.gameObject.CompareTag("enemigo") || collision.gameObject.CompareTag("trampa"))
        {
            // 
            GameManager.instance.vidas--;
          //  MOKEY.SetBool("jump", false);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("coin2"))
        {

            Coinsmove.StartCoinMove(other.transform.position, () => {
                GameManager.instance.coins++;
            });
      //      Destroy(other.gameObject);
           // Destroy(other.gameObject.GetComponent<Collider2D>());

           
        }
        if (other.gameObject.CompareTag("cabeza"))
        {
            Destroy(other.gameObject);
        }

    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class monkey : MonoBehaviour
{
   // 

    [SerializeField]
    float fuerzaSalto = 8.0f;
    public Animator MOKEY;
    public bool dano = false;
    public bool llaveActiva = false;
    float x = 1;
   
    Vector2 move;
    public float monedas = 0;
    public coinsManager coins;
    // GameManager gameManager;
    public Inputs inputActions;
  
    public Rigidbody2D rb;

  public  float velocidad;
    float direction = 0;
    bool isRuning = false;
    bool isJump;
 
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
    }
 
   
    void Update()
    {
        if (isRuning == true)
        {
            velocidad = 350f;
        }
        else
        {
            velocidad = 190f;
        }
        MovimientoPlayer();


        
    }
   public void atack()
    {
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
            transform.localScale = new Vector3(1F, 1, 1);
        }
        else
        {
            MOKEY.SetBool("run", true);
            //   MOKEY.SetBool("atack", false);
            transform.localScale = new Vector3(-1F, 1, 1);
        }
        if (direction == 0)
        {
            MOKEY.SetBool("run", false);
     
        }
      
    rb.velocity = new Vector2(direction * velocidad * Time.deltaTime, rb.velocity.y) ;
        

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

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        //if (other.CompareTag("coin"))
        //{
        ////    coins.SartCoinMove(other.transform.position);
        //   Destroy(other.gameObject);
        //    GameManager.instance.coins++;
        //   // monedas++;
        //}

    }
}

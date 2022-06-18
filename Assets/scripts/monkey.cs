using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class monkey : MonoBehaviour
{
    // 
     AudioSource audioSource;
    public AudioClip salto;
    public AudioClip damage;
    public AudioClip monedasS;
    public AudioClip vidasS;

    [SerializeField]
    float fuerzaSalto;

    public Animator MOKEY;
    public bool dano = false;

    public CoinCollection Coinsmove;
    // GameManager gameManager;
    public Inputs inputActions;
  
    public Rigidbody2D rb;
    [SerializeField]
  public  float velocidad;
public float direction = 0;
    bool isRuning = false;
    bool isJump;
    public Text vidaText;

    public GameObject gameover1;
    private void Awake()
    {
       // rb=GetComponent<Rigidbody2D>();
       gameover1.SetActive(false);
       audioSource = GetComponent<AudioSource>();
        inputActions = new Inputs();
        inputActions.Enable();
        inputActions.Player.move.performed += ctx => { direction = ctx.ReadValue<float>(); };
       // inputActions.Player.atack.performed += _ => atack();
        inputActions.Player.atack.canceled += _ => stopAtack();
        inputActions.Player.Jump.performed +=_=> jump();
        inputActions.Player.Jump.canceled +=_=> jumpStop();   

        GameManager.instance.vidas = 3;

    }
    private void OnEnable()
    {
        inputActions.Enable(); 
        inputActions.Player.Enable();
    }
    private void OnDisable()
    {
        inputActions.Disable();
        inputActions.Player.Disable();
    }


    void Start()
    {
      //  MOKEY = GetComponent<Animator>();
        vidaText.text=GameManager.instance.vidas.ToString();
    }
 
   
    void Update()
    {
        vidaText.text = GameManager.instance.vidas.ToString();
        if (GameManager.instance.vidas==0)
        {
            MOKEY.SetBool("dead",true);
         gameover1.SetActive(true);   
        }
     MovimientoPlayer();


        
    }
 
    public void stopAtack()
    {
      
        MOKEY.SetBool("atack", false);
    }
 
    public void MovimientoPlayer()
    {
        if (isJump==false)
        {
            MOKEY.SetBool("run", true);
        }
        rb.velocity = new Vector2(direction * velocidad, rb.velocity.y);
        if (direction < 0)
        {
            MOKEY.SetBool("run", true);
            transform.eulerAngles = new Vector3(0, 180, 0);
 
           
        }
      if(direction > 0)
        {
            MOKEY.SetBool("run", true);          
            transform.eulerAngles = new Vector3(0, 0, 0);
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
            audioSource.PlayOneShot(salto);
            MOKEY.SetBool("shot", false);
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
       
        if (collision.gameObject.CompareTag("enemigo") || collision.gameObject.CompareTag("trampa")||
            collision.gameObject.CompareTag("cohete"))
        {
            // 
            audioSource.PlayOneShot(damage);

            GameManager.instance.vidas--;
          //  MOKEY.SetBool("jump", false);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("coin2"))
        {
           // audioSource.PlayOneShot(monedasS);
           // Coinsmove.StartCoinMove(other.transform.position, () => {
           //     GameManager.instance.coins++;
           // });
           //Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("enemigo"))

        {
            // 
            audioSource.PlayOneShot(damage);

        }
        if (other.CompareTag("vida"))
        {
            audioSource.PlayOneShot(vidasS);
           
        }
    }
}

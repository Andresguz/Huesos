using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.InputSystem;
public class shot : MonoBehaviour
{
    public float shootSpeed;
    public float shootTime;
    public bool iSshooting;
    public Transform shotPos;
    public GameObject bullet;
    public Animator anim;
    //public Inputs inputActions;
   public AudioSource audioSource;
    public AudioClip disparoS;
    void Start()
    {
       // audioSource = GetComponent<AudioSource>();
        iSshooting = false;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)&&!iSshooting)
        {
            StartCoroutine(shott());
         
        }
       

     
    }
 
  public void shotButton()
    {
        if ( !iSshooting)
        {
            audioSource.PlayOneShot(disparoS);
            StartCoroutine(shott());
            //iSshooting = true;

        }
    }

    IEnumerator shott()
    {
        int direction()
        {
            if (transform.localScale.x < 0f)
            {
                return -1;
            }
            else
            {
                return +1;
            }
        };
        anim.SetTrigger("shot");
        iSshooting =true;
        GameObject newbullet=Instantiate(bullet,shotPos.position,shotPos.rotation);
        newbullet.GetComponent<Rigidbody2D>().velocity = new Vector2(shootSpeed*Time.fixedDeltaTime,0f);
        newbullet.transform.localScale = new Vector2(newbullet.transform.localScale.x *direction(),newbullet.transform.localScale.y);
        yield return new WaitForSeconds(shootTime);
        iSshooting = false;
    }
}

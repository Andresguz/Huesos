using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class destroyEnemy : MonoBehaviour
{
    public GameObject eliminacion;
  
    public int vida=100;
    private void Start()
    {
       // slider  =GetComponent<Slider>();
    }
    private void Update()
    {
       // slider.value = vida;

        if (vida ==0)
        {
           // Instantiate(eliminacion, gameObject.transform);
            Destroy(gameObject);    
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("bullet"))
        {
            vida -= 50;
            
          //  Destroy(gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonedaAnimator : MonoBehaviour
{
    public Animator animator;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(gameObject);
            //Destroy(gameObject.GetComponent<Collider2D>());
          // GetComponent<SpriteRenderer>().enabled = false;
           // Debug.Log("pp");
        //    animator.SetBool("coin", true);
        }
    }
}

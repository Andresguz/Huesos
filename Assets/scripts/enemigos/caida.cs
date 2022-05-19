using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class caida : MonoBehaviour
{

     void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag =="Player")
        {
            SceneManager.LoadScene(0);
            GameManager.instance.coins = 0;
            GameManager.instance.vidas--;
        }
    }
}

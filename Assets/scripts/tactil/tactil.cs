using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tactil : MonoBehaviour
{
    public Touch Toque;
    public CoinCollection Coinsmove;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount>0)
        {
            Toque = Input.GetTouch(0);
            Vector2 test = Camera.main.ScreenToWorldPoint(Toque.position);
            RaycastHit2D hit;
            hit=Physics2D.Raycast(test,Vector2.zero);
            if (hit.collider.CompareTag("coin"))
            {
                Coinsmove.StartCoinMove(hit.transform.position, () => {
                    GameManager.instance.coins++;
                });
                Destroy(hit.transform.gameObject);

            }
        }

        if (Input.GetMouseButtonDown(0))
        {
            //Toque = Input.GetTouch(0);
            Vector2 test = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit;
            hit = Physics2D.Raycast(test, Vector2.zero);
            if (hit.collider.CompareTag("coin"))
            {
                Coinsmove.StartCoinMove(hit.transform.position, () => {
                    GameManager.instance.coins++;
                });
                Destroy(hit.transform.gameObject);
                
            }
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("coin"))
        {
            ////    coins.SartCoinMove(other.transform.position);
            //Destroy(other.gameObject);
            //GameManager.instance.coins++;
            // monedas++;
        }

    }
}

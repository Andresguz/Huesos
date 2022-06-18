using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotEnemy : MonoBehaviour
{
    public Transform playerpPos;
    public float speed;
    public float distanceFreno;
    public float distanceRetraso;

    //public float tiempo;
    //public Transform PosShot;
    //public GameObject bulletEnemy;
    void Start()
    {
        playerpPos = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, playerpPos.position) > distanceFreno)
        {
            transform.position = Vector2.MoveTowards(transform.position, playerpPos.position, speed * Time.deltaTime);

        }
        if (Vector2.Distance(transform.position, playerpPos.position) < distanceRetraso)
        {
            transform.position = Vector2.MoveTowards(transform.position, playerpPos.position, -speed * Time.deltaTime);

        }


        if (Vector2.Distance(transform.position, playerpPos.position) < distanceFreno && Vector2.Distance(transform.position, playerpPos.position) >distanceRetraso)
        {
            transform.position = transform.position;

        }

        if (playerpPos.position.x>this.transform.position.x)
        {
            this.transform.localScale = new Vector2(-1, 1);
        }
        else
        {
            this.transform.localScale = new Vector2(1, 1);

        }

        //tiempo+=Time.deltaTime;
        //if (tiempo>=2)
        //{
        //    Instantiate(bulletEnemy, PosShot.position, Quaternion.identity);
        //    tiempo=0;
        //}
    }
}

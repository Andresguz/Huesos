using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shot : MonoBehaviour
{
    public float shootSpeed;
    public float shootTime;
    private bool iSshooting;
    public Transform shotPos;
    public GameObject bullet;
    void Start()
    {
        iSshooting = false;
    }

    // Update is called once per frame
    void Update()
    {
       // if (Input.GetButton(KeyCode.R) && iSshooting)
        {
            StartCoroutine(shott());
        }
    }
    IEnumerator shott()
    {
        int direction()
        {
            if (transform.localScale.x<0f)
            {
                return -1;
            }
            else
            {
                return +1;
            }
        };

        iSshooting=true;
        GameObject newbullet=Instantiate(bullet,shotPos.position,Quaternion.identity);
        newbullet.GetComponent<Rigidbody2D>().velocity = new Vector2(shootSpeed*Time.fixedDeltaTime,0f);
        newbullet.transform.localScale = new Vector2(newbullet.transform.localScale.x *direction(),newbullet.transform.localScale.y);
        yield return new WaitForSeconds(shootTime);
        iSshooting = false;
    }
}

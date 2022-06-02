using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FLYENEMY : MonoBehaviour
{
    private float tiempo;
    public GameObject bulletEnemy;
    public Transform PosShot;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tiempo += Time.deltaTime;
        if (tiempo >= 3)
        {
            Instantiate(bulletEnemy, PosShot.position, Quaternion.identity);
            tiempo = 0;
        }
    }
}

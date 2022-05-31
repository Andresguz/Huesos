using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotRaycast : MonoBehaviour
{
    public GameObject bullet;
    public Transform Spawn;
    public bool ray=true;
    [SerializeField]
    private LineRenderer lineRen;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (ray)
            {
               StartCoroutine(raycast_shot());
            }
           
        }
    }
   public void Laser() {
        if (ray)
        {
            StartCoroutine(raycast_shot());
        }
    }
    IEnumerator raycast_shot()
    {
        RaycastHit2D hit=Physics2D.Raycast(Spawn.position,Spawn.right);
        if(hit)
        {
            destroyEnemy enemy = hit.transform.GetComponent<destroyEnemy>();
            if(enemy!=null)
            enemy.vida -= 20;

            lineRen.SetPosition(0,Spawn.position);
            lineRen.SetPosition(1,hit.point);

        }
        else
        {
            lineRen.SetPosition(0,Spawn.position);
            lineRen.SetPosition(1,Spawn.position+Spawn.right * 100);
        }

        lineRen.enabled = true;
        yield return new WaitForSeconds(0.02f);
        lineRen.enabled=false;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotRaycast : MonoBehaviour
{
    public GameObject vfx;
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
        //if (Input.GetButtonDown("Fire1"))
        //{
        //    if (ray)
        //    {
        //       StartCoroutine(raycast_shot());
        //    }
           
        //}
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
        Quaternion rot = Quaternion.FromToRotation(Vector3.up, hit.normal);

        Vector3 pos = hit.point;
        if (hit)
        {
            destroyEnemy enemy = hit.transform.GetComponent<destroyEnemy>();
            if(enemy!=null)
            enemy.vida -= 50;

            lineRen.SetPosition(0,Spawn.position);
            lineRen.SetPosition(1,hit.point);
            Instantiate(vfx,pos,rot);
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

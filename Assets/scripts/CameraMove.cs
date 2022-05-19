using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
 //   public GameObject target;
    public ACTIVARMAPA ACTIVARMAPA;
    public Transform target;
    public float speed;
    public Vector3 pCamera;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ACTIVARMAPA.mapaa == false)
        {
            Vector3 Dposition=target.position+pCamera;
            Vector3 sposition =Vector3.Lerp(transform.position, Dposition, speed*Time.deltaTime);
            transform.position=sposition;

           // transform.position = new Vector3(target.transform.position.x, target.transform.position.y, transform.position.z);

        }
    }
}

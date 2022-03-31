using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animacionMonedas : MonoBehaviour
{
    public GameObject llegada;
    public GameObject monedas;
    bool monedasAc=false;
    void Start()
    {
      
    }

    
    void Update()
    {
        if (monedas.transform.position==llegada.transform.position)
        {
            monedasAc = true;
        }
        if (monedas==false)
        {
            monedas.transform.position += llegada.transform.position;
        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ACTIVARMAPA : MonoBehaviour
{
    public GameObject mapa;
    public GameObject close;
    public GameObject ZOOM;

   public bool mapaa;
    public PanZoom panzoom;
    void Start()
    {
       
        mapa.SetActive(false);
        close.SetActive(false);
        ZOOM.SetActive(false);
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            mapaa = !mapaa;
            if (mapaa)
            {
                activarmapa();
            }
            else
            {
                desactivarmapa();


            }
        }
        
    }
    public void activarmapa()
    {
       
        ZOOM.SetActive(true);
        mapa.SetActive(true);
        close.SetActive(true);
        mapaa=true;
    }
    public void desactivarmapa()
    {
        panzoom.screenl.text = "";
        mapa.SetActive(false);
        close.SetActive(false); 
        mapaa=false;
        ZOOM.SetActive(false);
    }
}

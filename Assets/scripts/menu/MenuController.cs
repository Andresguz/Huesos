using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    public Slider sliderVolumen;
    public float sliderValue;
    //public Image imageMute;


    public Slider sliderBrillo;
    public float sliderValueBrillo;
    public Image panelBrillo;
    void Start()
    {
        sliderVolumen.value = PlayerPrefs.GetFloat("volumenAudio", 0.5f);
        AudioListener.volume = sliderVolumen.value;

        //brillo
        panelBrillo.color = new Color(panelBrillo.color.r, panelBrillo.color.g, panelBrillo.color.b, sliderBrillo.value);

      //  revisa();
    }
    public void ChangeSlider(float valor)
    {
        sliderValue = valor;
        PlayerPrefs.SetFloat("volumenAudio",sliderValue);
        AudioListener.volume=sliderVolumen.value;
     //   revisa();
    }
    //public void revisa()
    //{
    //    if (sliderValue==0)
    //    {
    //        imageMute.enabled = true;
    //    }
    //    else
    //    {
    //        imageMute.enabled=false;    
    //    }
    //}
    

    public void ChangeBrillo(float valor)
    {
       sliderValueBrillo = valor;
        PlayerPrefs.SetFloat("brillo",sliderValueBrillo);
        panelBrillo.color = new Color(panelBrillo.color.r,panelBrillo.color.g,panelBrillo.color.b,sliderBrillo.value);

    }

}

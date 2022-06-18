using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class cargando : MonoBehaviour
{
    public Text texto;
    public Slider slider;
    private float v=0f;
   // public GameObject buttonS;
    private void Start()
    {
       // int nivelCargar = CambioNivel.siguienteLevel;
       // StartCoroutine(IniciarCarga(nivelCargar));
    }
    private void Update()
    {
        slider.value = v;
        v += 0.01f;
        if (v>1)
        {

            PlayerPrefs.SetInt("nivelX", 1);
            SceneManager.LoadScene("level1");
        }
    }
   
    //IEnumerator IniciarCarga(int nivel)
    //{
        
    //    yield return new WaitForSeconds(1f);
    //    AsyncOperation opercion = SceneManager.LoadSceneAsync(nivel);
    //    opercion.allowSceneActivation = false;

    //    while (!opercion.isDone)
    //    {
    //        if (opercion.progress >= 0.9f)
    //        {
    //            texto.text = "Presiona la Pantalla para continuar";
    //            if (Input.anyKey)
    //            {
    //                opercion.allowSceneActivation = true;
    //            }
    //        }
    //        yield return null;
    //    }
    //}
}

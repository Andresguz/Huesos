using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Botones : MonoBehaviour
{
    public GameObject btOpciones;
    public GameObject MenuP;
    private int nivel;

    public void Reinciar()
    {
       
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void CambiarScena()
    {

        //PlayerPrefs.SetInt("nivelX", 1);
        //SceneManager.LoadScene("level1");
        SceneManager.LoadScene("Carga");
    }
    public void ResumeScena()
    {
     nivel=   PlayerPrefs.GetInt("nivelX");
        if (nivel == 1)
        {
            SceneManager.LoadScene(1);
        }
        if (nivel == 2)
        {
            SceneManager.LoadScene(2);
        }
        if (nivel == 3)
        {
            SceneManager.LoadScene(3);
        }
    }
    private void Start()
    {
        MenuP.SetActive(true);
        btOpciones.SetActive(false);
    }
    public void ActiveMenuOP()
    {
        MenuP.SetActive(false);
        btOpciones.SetActive(true);
    }
    public void DesMenuOP()
    {
        MenuP.SetActive(true);

        btOpciones.SetActive(false);
    }

    public void exitGame()
    {
        Application.Quit();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botones : MonoBehaviour
{
    public GameObject btOpciones;
    public GameObject MenuP;

    public void CambiarScena()
    {
        CambioNivel.NivelCarga("level1");
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

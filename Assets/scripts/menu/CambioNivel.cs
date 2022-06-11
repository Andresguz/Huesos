using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public static class CambioNivel 
{
    public static string siguienteLevel;
    public static void NivelCarga(string nombre)
    {
        siguienteLevel = nombre;
        SceneManager.LoadScene("Carga"); 
    }

}

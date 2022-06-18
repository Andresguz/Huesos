using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public  class CambioNivel 
{
    public  int siguienteLevel;
    public  void NivelCarga(int i)
    {
      //  siguienteLevel = i;
        SceneManager.LoadScene(1); 
    }

}

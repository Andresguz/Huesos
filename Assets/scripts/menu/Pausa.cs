using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausa : MonoBehaviour
{
    [SerializeField] private GameObject botonPause;
    [SerializeField] private GameObject Menu;
   public void PausaGame()
    {
        Time.timeScale = 0f;
        botonPause.SetActive(false);
        Menu.SetActive(true);
    }
    public void reanudar()
    {
        Time.timeScale = 1f;
        botonPause.SetActive(true);
        Menu.SetActive(false);
    }
}

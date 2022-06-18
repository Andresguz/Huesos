using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOver : MonoBehaviour
{
    private int nivel;
    public void ResetLevel()
    {
        nivel = PlayerPrefs.GetInt("nivelX");
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
    public void menuM()
    {
        SceneManager.LoadScene(0);
    }
}

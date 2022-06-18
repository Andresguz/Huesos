using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AlmacenNivel : MonoBehaviour
{
   private int nivel;
    void Start()
    {
        nivel = PlayerPrefs.GetInt("nivelX");
        if (nivel==1)
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

    // Update is called once per frame
    void Update()
    {
        
    }
}

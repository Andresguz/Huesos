using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class changeScene : MonoBehaviour
{
    public int scene;
   public void cambioEscena()
    {
        SceneManager.LoadScene(scene);
    }
    public void cambioEscena1()
    {
        SceneManager.LoadScene(0);
    }
}

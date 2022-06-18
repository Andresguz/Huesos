using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int level;
    public int coins;
    public int vidas;
    
     void Awake()
    {
        MakeSinglenton();
        level = PlayerPrefs.GetInt("levelActual");
        coins = PlayerPrefs.GetInt("coinsGuardado");
        vidas = PlayerPrefs.GetInt("vidasActuales");
        //panelOver.SetActive(false); 
    }
    private void Update()
    {
        if (vidas == 0)
        {
            coins = 0;
          
            //  panelOver.SetActive(true);
        }
    }
    private void MakeSinglenton()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);  
        }
    }
}

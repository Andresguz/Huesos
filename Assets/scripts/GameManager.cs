using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int coins;
    public int vidas;
     void Awake()
    {
        MakeSinglenton();
    }
    private void Update()
    {
        if (vidas==0)
        {
            SceneManager.LoadScene(0);
            coins = 0;
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

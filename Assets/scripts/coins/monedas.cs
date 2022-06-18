using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class monedas : MonoBehaviour
{
    public Text contCoin;
  
    private void Start()
    {
        
    }
    public void Update()
    {
        //contCoin.text = monkey.monedas.ToString();
        contCoin.text = GameManager.instance.coins.ToString();
    }
}

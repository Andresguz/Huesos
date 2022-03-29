using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class monedas : MonoBehaviour
{
    public Text contCoin;
   public monkey monkey;
    private void Start()
    {
        
    }
    public void Update()
    {
        contCoin.text = monkey.monedas.ToString();
    }
}

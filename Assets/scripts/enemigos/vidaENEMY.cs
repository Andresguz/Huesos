using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class vidaENEMY : MonoBehaviour
{
    public Slider slider;
    public destroyEnemy enemy;
    private void Start()
    {

    }
    private void Update()
    {
        slider.value = enemy.vida;

        if (enemy.vida == 0)
        {
          
            Destroy(gameObject);
        }
    }
}

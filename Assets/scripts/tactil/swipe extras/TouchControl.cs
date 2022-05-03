using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class TouchControl : MonoBehaviour
{
    private Vector2 startPos;
    private Vector2 Direcion;

    private float angulo;

    public Text Texto;
    public Rigidbody2D Obj;

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            switch (touch.phase)
            {
                case TouchPhase.Began:

                    startPos = touch.position;

                    break;

                case TouchPhase.Moved:
                    Direcion = touch.position - startPos;

                    break;
                case TouchPhase.Ended:
                    angulo = Mathf.Atan2(Direcion.x,Direcion.y) * Mathf.Rad2Deg;

                    if (angulo >= -45 && angulo <= 45)
                    {
                        //arriba
                        Texto.text = "Arriba";
                      
                    }
                    if (angulo >= -135 && angulo <= -45)
                    {
                        //izquierda
                        Texto.text = "Izquierda";
                       
                    }
                    if (angulo >= 135 || angulo <= -135)
                    {
                        //abajo
                        Texto.text = "abajo";
                      
                    }
                    if (angulo >= 45 && angulo <= 135)
                    {
                        //derecha
                        Texto.text = "Derecha";
                       
                    }


                    break;
            }

        }
    }
}

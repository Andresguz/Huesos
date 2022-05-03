using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swipe : MonoBehaviour
{
    private Vector2 PosicionInicial;
    public float SwipeMinY; //0.5
    public float SwipeMinX; //0.5
    public monkey playerMono;
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                PosicionInicial = touch.position;
            }
            else if (touch.phase == TouchPhase.Ended)
            {
                float swipeVertical = (new Vector3(0, touch.position.y, 0) - new Vector3(0, PosicionInicial.y, 0)).magnitude;
                if (swipeVertical > SwipeMinY)
                {


                    float u = Mathf.Sign(touch.position.y -PosicionInicial.y);
                    if (u > 0)
                    {
                        print("Arriba");//Arriba
                        playerMono.jump();
                    }
                    if (u < 0)
                    {
                        print("Abajo");
                        playerMono.jumpStop();
                        //Abajo
                    }
                }
            }
            float swipeHorizontal = (new Vector3(touch.position.x, 0, 0) - new Vector3(PosicionInicial.x, 0, 0)).magnitude;
            if (swipeHorizontal > SwipeMinX)
            {
                float u = Mathf.Sign(touch.position.x - PosicionInicial.x);
                if (u > 0)
                {
                    print("Derecha");
                    //Derecha
                    playerMono.atack();
                }
                if (u < 0)
                {
                    print("Izquierda");
                    playerMono.atack();
                    //Izquierda
                }
                if (u == 0)
                {
                    playerMono.stopAtack();
                    playerMono.jumpStop();
                }
            }
        }
    }
}

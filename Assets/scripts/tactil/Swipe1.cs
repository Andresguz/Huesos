using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swipe1 : MonoBehaviour
{
    private Vector2 PosicionInicial;
    private Vector2 PosicionInicial2;
    public float SwipeMinY; //0.5
    public float SwipeMinX; //0.5
    public monkey playerMono;
 
    private void Awake()
    {
      
    }
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
                float swipeHorizontal = (new Vector3(touch.position.x, 0, 0) - new Vector3(PosicionInicial.x, 0, 0)).magnitude;

                if (swipeVertical > SwipeMinY && swipeVertical > swipeHorizontal)
                
                    {


                    float u = Mathf.Sign(touch.position.y -PosicionInicial.y);
                    if (u > 0)
                    {
                       // print("Arriba");//Arriba
                        playerMono.jump();
                    }
                 
                    if (u < 0)
                    {
                      //  print("Abajo");
                        //playerMono.jumpStop();
                        //Abajo
                    }
                  
                }


                //if (swipeHorizontal > SwipeMinX && swipeHorizontal > swipeVertical)
                //{
                //    float u = Mathf.Sign(touch.position.x - PosicionInicial.x);
                //    if (u > 0)
                //    {
                //        print("Derecha");
                //        //Derecha
                //        playerMono.atack();
                //    }
                //    if (u < 0)
                //    {
                //        playerMono.transform.localScale = new Vector3(1F, 1, 1);
                //        print("Izquierda");
                //        playerMono.atack2();

                //        //Izquierda
                //    }
                //    //if (u == 0)
                //    //{
                //    //    playerMono.stopAtack();
                //    //    playerMono.jumpStop();
                //    //}
                //}
            }

        }

        if (Input.GetMouseButtonDown(0)) {
                PosicionInicial2 = new Vector3(Input.mousePosition.x, Input.mousePosition.y);
            }
        if(Input.GetMouseButtonUp(0))
        {
            float swipeVertical2 = (new Vector3(0, Input.mousePosition.y, 0) - new Vector3(0, PosicionInicial2.y, 0)).magnitude;
            float swipeHorizontal2 = (new Vector3(Input.mousePosition.x, 0, 0) - new Vector3(PosicionInicial2.x, 0, 0)).magnitude;

            if (swipeVertical2 > SwipeMinY && swipeVertical2 > swipeHorizontal2)
            {


                float u = Mathf.Sign(Input.mousePosition.y - PosicionInicial2.y);
                Debug.Log(u);
              
                if (u > 0)
                {
                    print("Arriba Mouse");//Arriba
                    playerMono.jump();
                }
             
                if (u < 0)
                {
                    print("Abajo mouse");
                
                }
             
            }
            //else
            //{

            //    if (swipeHorizontal2 > SwipeMinX && swipeHorizontal2 > swipeVertical2)
            //    {
            //        float u = Mathf.Sign(Input.mousePosition.x - PosicionInicial2.x);

            //        if (u > 0)
            //        {
            //            print("Derecha mouse");
            //            playerMono.atack();
            //            //Derecha
            //        }
            //        if (u < 0)
            //        {
            //            print("Izquierda mouse");
            //            playerMono.atack2();
                       
            //            // playerMono.stopAtack();
            //            //Izquierda
            //        }
                  
            //    }

            //}
            
        }





    }
}

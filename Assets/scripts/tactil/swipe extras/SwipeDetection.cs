using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;
using TMPro;

public class SwipeDetection : MonoBehaviour
{
    //private MobileControls controls;
    //private Coroutine coroutine;
    ////
    //public TextMeshProUGUI txtRes;

    //private void Awake() {
    //    controls = new MobileControls();
    //}
    //private void OnEnable() {
    //    controls.Enable();
    //}
    //private void OnDisable() {
    //    controls.Disable();
    //}
    //private void Start() {
    //    controls.Touch.PrimaryFingerPosition.started += _ => SwipeStart();
    //    controls.Touch.PrimaryFingerPosition.canceled += _ => SwipeEnd();
    //}
    //private void SwipeStart()
    //{
    //    coroutine = StartCoroutine("SwipeCoroutine");
    //}
    //private void SwipeEnd()
    //{
    //    StopCoroutine(coroutine);
    //}
    //private IEnumerator SwipeCoroutine()
    //{
    //    Vector2 previousPosition = Vector2.zero;
    //    while(true)
    //    {
    //        Vector2 newPosition = controls.Touch.PrimaryFingerPosition.ReadValue<Vector2>();
    //        if(newPosition.x > previousPosition.x) OnSwipe_Right();
    //        else if(newPosition.x < previousPosition.x) OnSwipe_Left();

    //        if(newPosition.y > previousPosition.y) OnSwipe_Up();
    //        else if(newPosition.y < previousPosition.y) OnSwipe_Down();

    //        if(newPosition == previousPosition) txtRes.text = "...";
    //    }
    //}
    //private void OnSwipe_Right()
    //{
    //    txtRes.text = "Derecha!";
    //}
    //private void OnSwipe_Left()
    //{
    //    txtRes.text = "Izquierda!";
    //}
    //private void OnSwipe_Up()
    //{
    //    txtRes.text = "Arriba!";
    //}
    //private void OnSwipe_Down()
    //{
    //    txtRes.text = "Abajo!";
    //}
}
